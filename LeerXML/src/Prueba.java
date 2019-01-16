import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.Writer;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import Sentencias_BBDD.*;

import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import Modelo.Alojamiento;
import Modelo.CodigoPostal;
import Modelo.Municipio;
import Modelo.RelacionEntreCod;
import Modelo.TipoAlbergueEuskera;

//DEFINITIVO

public class Prueba {

	public static void main(String[] args) {
		try {
			// ARRAYS PARA POBLAR LAS TABLAS
			ArrayList<Modelo.Alojamiento> alojamientos = new ArrayList<Modelo.Alojamiento>();
			ArrayList<Modelo.Categorias> categorias = new ArrayList<Modelo.Categorias>();
			ArrayList<Modelo.CodigoPostal> codigosPostales = new ArrayList<Modelo.CodigoPostal>();
			ArrayList<Modelo.Municipio> municipios = new ArrayList<Modelo.Municipio>();
			ArrayList<Modelo.Provincia> provincias = new ArrayList<Modelo.Provincia>();
			ArrayList<Modelo.TipoAlbergue> tiposAlbergues = new ArrayList<Modelo.TipoAlbergue>();
			ArrayList<Modelo.TipoAlbergueEuskera> tiposAlberguesEuskera = new ArrayList<Modelo.TipoAlbergueEuskera>();
			ArrayList<Modelo.RelacionEntreCod> relacionEntreCods=new ArrayList<Modelo.RelacionEntreCod>();
			ArrayList<String> ficherosXML = new ArrayList<String>();
			ArrayList<String> ficherosXMLEuskera = new ArrayList<String>();
			
			inicializarArrays(Prueba.class.getResource("/Resources/MunicipioProvinciaCP.txt").getPath(), municipios, codigosPostales, relacionEntreCods);
			ficherosXML.add(Prueba.class.getResource("/Resources/alojamientos_albergues.xml").getPath());
			ficherosXML.add(Prueba.class.getResource("/Resources/alojamientos_camping.xml").getPath());
			ficherosXML.add(Package.class.getResource("/Resources/alojamientos_rural.xml").getPath());

			ficherosXMLEuskera.add(Prueba.class.getResource("/Resources/alojamientos_albergues_eus.xml").getPath());
			ficherosXMLEuskera.add(Prueba.class.getResource("Resources/alojamientos_camping_eus.xml").getPath());
			ficherosXMLEuskera.add(Prueba.class.getResource("/Resources/alojamientos_rural_eus.xml").getPath());

			cambiarCaracteresEspeciales(ficherosXML);
			cambiarCaracteresEspeciales(ficherosXMLEuskera);

			parseXMLs(alojamientos, categorias, codigosPostales, municipios, provincias, tiposAlbergues, relacionEntreCods, ficherosXML);
			parseXMLsEuskera(alojamientos, tiposAlberguesEuskera, ficherosXMLEuskera);
			for (Alojamiento alojamiento : alojamientos) {
				if (alojamiento.getFirma() == null)
					alojamientos.remove(alojamiento);
			}
			//creacionBBDD_Tablas("reto_gp2", "kasserver.synology.me", 3307, "gp2", "NuG7FqwibR1ZAuKy");
			//poblarTablas("reto_gp2", " kasserver.synology.me", 3307, "gp2", "NuG7FqwibR1ZAuKy", alojamientos, categorias, codigosPostales, municipios, provincias, tiposAlbergues, tiposAlberguesEuskera, relacionEntreCods);
			creacionBBDD_Tablas("labetxe", "localhost", 0, "root", "");
			poblarTablas("labetxe", "localhost", 0, "root", "", alojamientos, categorias,codigosPostales, municipios, provincias, tiposAlbergues,tiposAlberguesEuskera,relacionEntreCods);
			Conexion.cerrar1();

		} catch (SAXException e) {
			e.printStackTrace();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

	private static void cambiarCaracteresEspeciales(ArrayList<String> ficherosXMLEuskera)
			throws FileNotFoundException, IOException {
		for (String fichero : ficherosXMLEuskera) {
			BufferedReader br = new BufferedReader(
					new InputStreamReader(new FileInputStream(fichero), StandardCharsets.UTF_8));
			String info = "", aux;
			while ((aux = br.readLine()) != null) {
				aux = aux.replaceAll("&amp;lt;.*?&amp;gt;", "");
				aux = aux.replaceAll("&amp;apos;", "'");
				aux = aux.replaceAll("&amp;amp;", "and");
				aux = aux.replaceAll("&amp;amp;ldquo", "“");
				aux = aux.replaceAll("&amp;rdquo;", "”");
				aux = aux.replaceAll("&amp;aacute;", "á");
				aux = aux.replaceAll("&amp;sup2;", "²");
				aux = aux.replaceAll("&amp;nbsp;", " ");
				aux = aux.replaceAll("&amp;hellip;", "…");
				aux = aux.replaceAll("&amp;ntilde;", "ñ");
				aux = aux.replaceAll("&amp;#8239;", "");

				info += aux;
			}
			br.close();
			Writer w = null;
			w = new OutputStreamWriter(new FileOutputStream(fichero), StandardCharsets.UTF_8);
			w.write(info);
			w.close();
		}
	}

	private static void inicializarArrays(String nombreFicheroTexto, ArrayList<Modelo.Municipio> municipios,
			ArrayList<Modelo.CodigoPostal> codigosPostales, ArrayList<Modelo.RelacionEntreCod> relacionEntreCodigos) {
		if (codigosPostales.isEmpty())
			codigosPostales.add(new CodigoPostal(-1));
		BufferedReader bf=null;
		try {
			bf= new BufferedReader(new FileReader(new File(nombreFicheroTexto)));
			String leido = bf.readLine();
			while ((leido=bf.readLine() )!= null) {
				String[] datos = leido.split(";");
				Municipio municipio = new Municipio(Integer.valueOf(datos[1]), datos[3]);
				CodigoPostal codigoPostal = new CodigoPostal(Integer.valueOf(datos[2]));
				if (!municipios.contains(municipio))
				{
					if(municipios.isEmpty())
						municipio.setIndice(1);
					else
						municipio.setIndice(municipios.get(municipios.size()-1).getIndice()+1);
					municipios.add(municipio);
				}
				if (!codigosPostales.contains(codigoPostal))
					codigosPostales.add(codigoPostal);
				RelacionEntreCod relacionEntreCod = new RelacionEntreCod(municipios.get(municipios.indexOf(municipio)).getIndice(), Integer.valueOf(datos[0]),
						codigoPostal.getCodigoPostal());
				if (relacionEntreCodigos.isEmpty()) {
					relacionEntreCod.setId(0);
					relacionEntreCodigos.add(relacionEntreCod);
				} else if (!relacionEntreCodigos.contains(relacionEntreCod)) {
					relacionEntreCod.setId(relacionEntreCodigos.get(relacionEntreCodigos.size() - 1).getId() + 1);
					relacionEntreCodigos.add(relacionEntreCod);
				}

			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		finally {
			if(bf!=null)
				try {
					bf.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
		}

	}

	private static void parseXMLs(ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<Modelo.Categorias> categorias,
			ArrayList<Modelo.CodigoPostal> codigosPostales, ArrayList<Modelo.Municipio> municipios,
			ArrayList<Modelo.Provincia> provincias, ArrayList<Modelo.TipoAlbergue> tiposAlbergues,
			ArrayList<Modelo.RelacionEntreCod> relacionEntreCods, ArrayList<String> ficherosXML) throws SAXException, IOException, FileNotFoundException {
		XMLReader reader = XMLReaderFactory.createXMLReader();
		reader.setContentHandler(
				new AlojamientoSAX(alojamientos, categorias, codigosPostales, municipios, provincias, tiposAlbergues, relacionEntreCods));
		for (String fichero : ficherosXML) {
			reader.parse(new InputSource(new FileInputStream(new File(fichero))));
		}
	}

	private static void parseXMLsEuskera(ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<TipoAlbergueEuskera> tipoAlbergueEuskeras, ArrayList<String> ficherosXMLEuskera)
			throws SAXException, IOException, FileNotFoundException {
		XMLReader reader = XMLReaderFactory.createXMLReader();
		reader.setContentHandler(new AlojamientoSAX_INFO_EUSKERA(alojamientos, tipoAlbergueEuskeras));
		for (String fichero : ficherosXMLEuskera) {
			reader.parse(new InputSource(new FileInputStream(new File(fichero))));
		}
	}

	private static void creacionBBDD_Tablas(String dataBase, String url, int port, String user, String password) {

		Conexion.conectar1(dataBase, url, port, user, password);

		// TABLA MUNICIPIOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS MUNICIPIOS( " + "CODIGO NUMERIC(3), "
				+ "MUNICIPIO VARCHAR(50), " + "INDICE NUMERIC(4) PRIMARY KEY" + ");");

		// TABLA PROVINCIAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS PROVINCIAS( " + "CODIGO NUMERIC(2) PRIMARY KEY, "
				+ "PROVINCUA VARCHAR(50));");

		// TABLA TIPOS
		Sentencias.sentenciaNoSelectiva(
				"CREATE TABLE IF NOT EXISTS TIPOS( " + "CODIGO NUMERIC(4) PRIMARY KEY, " + "TIPO VARCHAR(25)" + ");");

		// TABLA TIPOS EUSKERA
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS TIPOS_EUSKERA( " + "CODIGO NUMERIC(4) PRIMARY KEY, "
				+ "TIPO_EUSKERA VARCHAR(25)" + ");");

		// TABLA CATEGORIAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS CATEGORIAS( " + "CODIGO NUMERIC(4) PRIMARY KEY, "
				+ "CATEGORIA VARCHAR(25));");

		// TABLA CODIGOS_POSTALES
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS CODIGOS_POSTALES( CODIGO_POSTAL NUMERIC(5) PRIMARY KEY);");
		// TABALA RELACIONES ENTRE CODIGOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS RELACION_CP_MUNICIPIOS_PROVINCIAS( "
				+"ID NUMERIC(5) PRIMARY KEY, "
				//CLAVES FORÁNEAS
				+"CODIGO_POSTAL NUMERIC (5), "
				+"CODIGO_PROVINCIA NUMERIC(2), "
				+"INDICE_MUNICIPIO NUMERIC(4), "
				//CONSTRAINTS	
				+"FOREIGN KEY (INDICE_MUNICIPIO) REFERENCES MUNICIPIOS(INDICE), "
				+"FOREIGN KEY (CODIGO_PROVINCIA) REFERENCES PROVINCIAS(CODIGO), "
				+"FOREIGN KEY (CODIGO_POSTAL) REFERENCES CODIGOS_POSTALES(CODIGO_POSTAL)" + ");");

		// TABLA ALOJAMIENTOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS ALOJAMIENTOS( "
				+ "FIRMA VARCHAR(8) NOT NULL PRIMARY KEY, " + "NOMBRE VARCHAR(50) NOT NULL, "
				+ "DESCRIPCION_ABREVIADA VARCHAR(110), " + "DESCRIPCION_ABREVIADA_EUSKERA VARCHAR(110),"
				+ "DESCRIPCION VARCHAR(1500), " + "DESCRIPCION_EUSKERA VARCHAR(1500), " + "TELEFONO VARCHAR(15), "
				+ "DIRECCION VARCHAR(250) NOT NULL, " + "CALIDAD_ASEGURADA BOOLEAN, " + "EMAIL VARCHAR(50), "
				+ "WEB VARCHAR(100), " + "CLUB BOOLEAN, " + "RESTAURANTE BOOLEAN, " + "AUTOCARAVANA BOOLEAN, "
				+ "TIENDA BOOLEAN, " + "CAPACIDAD NUMERIC(3), " + "GASTRONOMICO BOOLEAN, " + "SURFING BOOLEAN, "
				+ "COORDENADAS VARCHAR(200),"
				// CLAVES FORÁNEAS
				+ "CODIGO_TIPOS NUMERIC(4), "
				+ "CODIGO_TIPOS_EUSKERA NUMERIC(4), " + "CODIGO_CATEGORIAS NUMERIC(4), "
				+ "ID_RELACIONES NUMERIC(5), "
				// CONSTRAINTS
				+ "FOREIGN KEY (ID_RELACIONES) REFERENCES RELACION_CP_MUNICIPIOS_PROVINCIAS(ID), "
				+ "FOREIGN KEY (CODIGO_TIPOS) REFERENCES TIPOS(CODIGO), "
				+ "FOREIGN KEY (CODIGO_TIPOS_EUSKERA) REFERENCES TIPOS_EUSKERA(CODIGO), "
				+ "FOREIGN KEY (CODIGO_CATEGORIAS) REFERENCES CATEGORIAS(CODIGO)"
				+ ");");

		// TABLA USUARIOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS USUARIOS( "
				+ "NOMBRE_USUARIO VARCHAR(15) PRIMARY KEY, " + "CONTRASENIA VARCHAR(40) NOT NULL, "
				+ "NOMBRE VARCHAR(20) NOT NULL, " + "APELLIDOS VARCHAR(50) NOT NULL, "
				+ "EMAIL VARCHAR(50) UNIQUE NOT NULL, " + "TELEFONO VARCHAR(15) NOT NULL, " + "PERFIL VARCHAR(1));");

		// TABLA RESERVAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS RESERVAS(" + "ID NUMERIC(4) PRIMARY KEY, "
				+ "NOMBRE_RESERVA VARCHAR(20), " + "NOMBRE_CLIENTE VARCHAR(15), " + "FIRMA_ALOJAMIENTO VARCHAR(8), "
				// CLAVES FORÁNEAS
				+ "FOREIGN KEY (NOMBRE_CLIENTE) REFERENCES USUARIOS(NOMBRE_USUARIO), "
				+ "FOREIGN KEY (FIRMA_ALOJAMIENTO) REFERENCES ALOJAMIENTOS(FIRMA));");

	}
	
	private static void poblarTablas(String dataBase, String url, int port, String user, String password,
			ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<Modelo.Categorias> categorias,
			ArrayList<Modelo.CodigoPostal> codigosPostales, ArrayList<Modelo.Municipio> municipios,
			ArrayList<Modelo.Provincia> provincias, ArrayList<Modelo.TipoAlbergue> tiposAlbergues,
			ArrayList<Modelo.TipoAlbergueEuskera> tiposAlberguesEuskeras, ArrayList<Modelo.RelacionEntreCod> relacionEntreCods) {
		Conexion.conectar1(dataBase, url, port, user, password);
		for (Modelo.Municipio municipio : municipios) {
			Sentencias_BBDD_Alojamientos.insertarMunicipios(municipio.getIndice(), municipio.getCod(),
					municipio.getMunicipio());
		}
		for (Modelo.Provincia provincia : provincias) {
			Sentencias_BBDD_Alojamientos.insertarEnTablaIDString("PROVINCIAS", provincia.getCod(),
					provincia.getProvincia());
		}
		for (Modelo.TipoAlbergue tipoAlbergue : tiposAlbergues) {
			Sentencias_BBDD_Alojamientos.insertarEnTablaIDString("TIPOS", tipoAlbergue.getId(), tipoAlbergue.getTipo());
		}
		for (Modelo.TipoAlbergueEuskera tipoAlbergue : tiposAlberguesEuskeras) {
			Sentencias_BBDD_Alojamientos.insertarEnTablaIDString("TIPOS_EUSKERA", tipoAlbergue.getId(),
					tipoAlbergue.getTipoEuskera());
		}
		for (Modelo.Categorias categoria : categorias) {
			Sentencias_BBDD_Alojamientos.insertarEnTablaIDString("CATEGORIAS", categoria.getId(),
					String.valueOf(categoria.getCategoria()));
		}
		for (Modelo.CodigoPostal codigoPostal : codigosPostales) {
			Sentencias_BBDD_Alojamientos.insertarCodigos_Postales(codigoPostal.getCodigoPostal());
		}
		for(Modelo.RelacionEntreCod relacionEntreCod : relacionEntreCods)
		{
			Sentencias_BBDD_Alojamientos.insertarRelacion(relacionEntreCod.getId(), relacionEntreCod.getiDCodigoPostal(), 
					relacionEntreCod.getCodigoProvincia(), relacionEntreCod.getCodigoMunicipio());
		}
		for (Modelo.Alojamiento alojamiento : alojamientos) {
			Sentencias_BBDD_Alojamientos.insertarAlojamiento(alojamiento.getFirma(), alojamiento.getNombre(),
					alojamiento.getDescripcionAbreviada(), alojamiento.getDescripcionEuskera(),
					alojamiento.getDescripcionNOAbreviada(), alojamiento.getDescripcionNOAbreviadaEuskera(),
					alojamiento.getTelefono(), alojamiento.getDireccion(), alojamiento.isCalidadAsegurada(),
					alojamiento.getEmail(), alojamiento.getWebURL(), alojamiento.isClub(), alojamiento.isRestaurant(),
					alojamiento.isAutocaravana(), alojamiento.isTienda(), alojamiento.getCapacidad(),
					alojamiento.isGastronomico(), alojamiento.isSurfing(), alojamiento.getCoordenadas(),
					alojamiento.getTipo().getId(), alojamiento.getTipoEuskera().getId(),
					alojamiento.getCategoria().getId(),
					alojamiento.getRelacionEntreCod().getId());
		}

	}

}
