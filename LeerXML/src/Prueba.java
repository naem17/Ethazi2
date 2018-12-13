import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;

import org.hibernate.cfg.Configuration;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import com.mysql.cj.Session;
import com.mysql.cj.xdevapi.SessionFactory;

public class Prueba {

	public static void main(String[] args) {
		try {
			//ARRAYS PARA POBLAR LAS TABLAS
			ArrayList<Modelo.Alojamiento> alojamientos=new ArrayList<Modelo.Alojamiento>();
			ArrayList<Modelo.Categorias> categorias=new ArrayList<Modelo.Categorias>();
			ArrayList<Modelo.CodigoPostal> codigosPostales=new ArrayList<Modelo.CodigoPostal>();
			ArrayList<Modelo.Municipio> municipios=new ArrayList<Modelo.Municipio>();
			ArrayList<Modelo.Provincia> provincias=new ArrayList<Modelo.Provincia>();
			ArrayList<Modelo.TipoAlbergue> tiposAlbergues=new ArrayList<Modelo.TipoAlbergue>();
			ArrayList<String> ficherosXML=new ArrayList<String>();
			ficherosXML.add("alojamientos1.xml");
			ficherosXML.add("alojamientos2.xml");
			ficherosXML.add("alojamientos.xml");
			
			parseXMLs(alojamientos, categorias, codigosPostales, municipios, provincias, tiposAlbergues, ficherosXML);
			for(int i=0; i<alojamientos.size();i++)
				System.out.println(alojamientos.get(i).toString());
			creacionBBDD_Tablas("localhost","root","");
			
			//Hibernate 
			org.hibernate.SessionFactory sessionFactory=new Configuration().configure().buildSessionFactory();
			org.hibernate.Session session= sessionFactory.openSession();
			session.beginTransaction();
			
			for(int i=0; i<municipios.size();i++)
				session.save(municipios.get(i));
			Conexion.cerrar1();
			
		} catch (SAXException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	private static void parseXMLs(ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<Modelo.Categorias> categorias,
								  ArrayList<Modelo.CodigoPostal> codigosPostales,ArrayList<Modelo.Municipio> municipios,
								  ArrayList<Modelo.Provincia> provincias,ArrayList<Modelo.TipoAlbergue> tiposAlbergues,
								  ArrayList<String> ficherosXML)
			throws SAXException, IOException, FileNotFoundException {
		XMLReader reader = XMLReaderFactory.createXMLReader();
		reader.setContentHandler(new AlojamientoSAX(alojamientos, categorias, codigosPostales, municipios, provincias, tiposAlbergues));
		for (String fichero : ficherosXML) {
			reader.parse(new InputSource(new FileInputStream(new File(fichero))));
		}
	}

	private static void creacionBBDD_Tablas(String url, String user, String password) {
		Conexion.conectarNoAUnaBD(url, user, password);
		Sentencias.sentenciaNoSelectiva("CREATE DATABASE IF NOT EXISTS LABETXE;");
		Conexion.cerrar1();
		
		Conexion.conectar1("LABETXE", url, user, password);
		
		//TABLA MUNICIPIOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS MUNICIPIOS( "
				+ "CODIGO NUMERIC(3) PRIMARY KEY, "
				+ "MUNICIPIO VARCHAR(50));");
		
		//TABLA PROVINCIAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS PROVINCIAS( "
				+ "CODIGO NUMERIC(2) PRIMARY KEY, "
				+ "PROVINCUA VARCHAR(50));");
		
		//TABLA TIPOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS TIPOS( "
				+ "CODIGO NUMERIC(4) PRIMARY KEY, "
				+ "TIPO VARCHAR(25));");
		
		//TABLA CATEGORIAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS CATEGORIAS( "
				+ "CODIGO NUMERIC(4) PRIMARY KEY, "
				+ "CATEGORIA VARCHAR(25));");
		
		//TABLA CODIGOS_POSTALES
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS CODIGOS_POSTALES( "
				+ "ID NUMERIC(5) PRIMARY KEY, "
				+ "CODIGO_POSTAL NUMERIC(5));");
		
		//TABLA ALOJAMIENTOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS ALOJAMIENTOS( "
				+ "NOMBRE VARCHAR(50) NOT NULL, "
				+ "DESCRIPCION_ABREVIADA VARCHAR(100), "
				+ "DESCRIPCION VARCHAR(1500), "
				+ "TELEFONO VARCHAR(15) NOT NULL, "
				+ "DIRECCION VARCHAR(250) NOT NULL, "
				+ "CALIDAD_ASEGURADA BOOLEAN, "
				+ "EMAIL VARCHAR(50) NOT NULL, "
				+ "WEB VARCHAR(100), "
				+ "CLUB BOOLEAN, "
				+ "RESTAURANTE BOOLEAN, "
				+ "AUTOCARAVANA BOOLEAN, "
				+ "TIENDA BOOLEAN, "
				+ "CAPACIDAD NUMERIC(3), "
				+ "GASTRONOMICO BOOLEAN, "
				+ "SURFING BOOLEAN, "
				+ "COORDENADAS VARCHAR(200), "
				//CLAVES FORÁNEAS
				+ "CODIGO_MUNICIPIO NUMERIC(3), "
				+ "CODIGO_PROVINCIA NUMERIC(2), "
				+ "CODIGO_TIPOS NUMERIC(4), "
				+ "CODIGO_CATEGORIAS NUMERIC(4), "
				+ "ID_CODIGO_POSTAL NUMERIC(5), "
				//CONSTRAINTS
				+ "PRIMARY KEY(NOMBRE, DIRECCION, COORDENADAS), "
				+ "FOREIGN KEY (CODIGO_MUNICIPIO) REFERENCES MUNICIPIOS(CODIGO), "
				+ "FOREIGN KEY (CODIGO_PROVINCIA) REFERENCES PROVINCIAS(CODIGO), "
				+ "FOREIGN KEY (CODIGO_TIPOS) REFERENCES TIPOS(CODIGO), "
				+ "FOREIGN KEY (CODIGO_CATEGORIAS) REFERENCES CATEGORIAS(CODIGO), "
				+ "FOREIGN KEY (ID_CODIGO_POSTAL) REFERENCES CODIGOS_POSTALES(ID)"
				+ ");");
		
		//TABLA USUARIOS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS USUARIOS( "
				+ "NOMBRE_USUARIO VARCHAR(15) PRIMARY KEY, "
				+ "CONTRASENIA VARCHAR(10) NOT NULL, "
				+ "NOMBRE VARCHAR(15) NOT NULL, "
				+ "APELLIDOS VARCHAR(50) NOT NULL, "
				+ "EMAIL VARCHAR(50) UNIQUE NOT NULL, "
				+ "PERFIL VARCHAR(1));");
		
		//TABLA CLIENTES
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS CLIENTES( "
				+ "NOMBRE_USUARIO VARCHAR(15) PRIMARY KEY, "
				+ "CONTRASENIA VARCHAR(10) NOT NULL, "
				+ "NOMBRE VARCHAR(20) NOT NULL, "
				+ "APELLIDOS VARCHAR(50) NOT NULL, "
				+ "EMAIL VARCHAR(50) UNIQUE NOT NULL, "
				+ "TELEFONO VARCHAR(15) NOT NULL);");
		
		//TABLA RESERVAS
		Sentencias.sentenciaNoSelectiva("CREATE TABLE IF NOT EXISTS RESERVAS("
				+ "ID NUMERIC(4) PRIMARY KEY, "
				+ "NOMBRE_REVERVA VARCHAR(20), "
				+ "NOMBRE_CLIENTE VARCHAR(15) NOT NULL, "
				+ "NOMBRE_ALOJAMIENTO VARCHAR(50) NOT NULL, "
				+ "DIRECCION_ALOJAMIENTO VARCHAR(250), "
				+ "COORDENADAS_ALOJAMIENTO VARCHAR(200), "
				//CLAVES FORÁNEAS
				+ "FOREIGN KEY (NOMBRE_CLIENTE) REFERENCES CLIENTES(NOMBRE_USUARIO), "
				+ "FOREIGN KEY (NOMBRE_ALOJAMIENTO, DIRECCION_ALOJAMIENTO, COORDENADAS_ALOJAMIENTO) REFERENCES ALOJAMIENTOS(NOMBRE, DIRECCION, COORDENADAS));");
	}

}
