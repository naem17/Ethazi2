import java.util.ArrayList;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import Modelo.Categorias;
import Modelo.CodigoPostal;
import Modelo.Municipio;
import Modelo.Provincia;
import Modelo.TipoAlbergue;

public class AlojamientoSAX extends DefaultHandler {

	private ArrayList<Modelo.Alojamiento> alojamientos;
	private ArrayList<Modelo.Categorias> categorias;
	private ArrayList<Modelo.CodigoPostal> codigosPostales;
	private ArrayList<Modelo.Municipio> municipios;
	private ArrayList<Modelo.Provincia> provincias;
	private ArrayList<Modelo.TipoAlbergue> tiposAlbergues;
	private String valorAux;

	public AlojamientoSAX(ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<Modelo.Categorias> categorias,
			ArrayList<Modelo.CodigoPostal> codigosPostales, ArrayList<Modelo.Municipio> municipios,
			ArrayList<Modelo.Provincia> provincias, ArrayList<Modelo.TipoAlbergue> tiposAlbergues) {

		this.alojamientos = alojamientos;
		this.categorias = categorias;
		this.codigosPostales = codigosPostales;
		this.municipios = municipios;
		this.provincias = provincias;
		this.tiposAlbergues = tiposAlbergues;

		valorAux = null;
	}

	@Override
	public void characters(char[] ch, int start, int length) throws SAXException {
		valorAux = new String(ch, start, length);
	}

	@Override
	public void endElement(String uri, String localName, String qName) throws SAXException {
		// Guarda el nombre del último Alojamiento
		if (localName.compareToIgnoreCase("documentname") == 0)
			alojamientos.get(alojamientos.size() - 1).setNombre(valorAux);
		// Guarda la descripción abreviada y ampliada del último Alojamiento
		if (localName.compareToIgnoreCase("turismdescription") == 0 
				&& alojamientos.get(alojamientos.size() - 1).getDescripcionAbreviada() == null)
			alojamientos.get(alojamientos.size() - 1).setDescripcionAbreviada(valorAux);
		else if (localName.compareToIgnoreCase("turismdescription") == 0
				&& alojamientos.get(alojamientos.size() - 1).getDescripcionNOAbreviada() == null)
			alojamientos.get(alojamientos.size() - 1).setDescripcionNOAbreviada(valorAux);
		// Guarda el teléfono
		if (localName.compareToIgnoreCase("phone") == 0)
			alojamientos.get(alojamientos.size() - 1).setTelefono(valorAux);
		// Guarda la dirección
		if (localName.compareToIgnoreCase("address") == 0)
			alojamientos.get(alojamientos.size() - 1).setDireccion(valorAux);
		// Guarda calidad
		if (localName.compareToIgnoreCase("qualityassurance") == 0)
			alojamientos.get(alojamientos.size() - 1).setCalidadAsegurada(valorAux.contains("1"));
		// Guarda correo electrónico
		if (localName.compareToIgnoreCase("tourismemail") == 0)
			alojamientos.get(alojamientos.size() - 1).setEmail(valorAux);
		// Guarda página web
		if (localName.compareToIgnoreCase("web") == 0)
			alojamientos.get(alojamientos.size() - 1).setWebURL(valorAux);
		// Guarda tipo de albergue
		if (localName.compareToIgnoreCase("lodgingtype") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < tiposAlbergues.size()) {
				existe = (valorAux.compareToIgnoreCase(tiposAlbergues.get(i).getTipo()) == 0);
				i++;
			}
			if (existe)
				alojamientos.get(alojamientos.size() - 1).setTipo(tiposAlbergues.get(i-1));
			else {
				if (tiposAlbergues.isEmpty())
					tiposAlbergues.add(new TipoAlbergue(0, valorAux));
				else {
					tiposAlbergues
							.add(new TipoAlbergue(tiposAlbergues.get(tiposAlbergues.size() - 1).getId() + 1, valorAux));
				}
				alojamientos.get(alojamientos.size() - 1).setTipo(tiposAlbergues.get(tiposAlbergues.size() - 1));
			}
		}
		// Guarda categoría
		if (localName.compareToIgnoreCase("category") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < categorias.size()) {
				existe = (valorAux.compareToIgnoreCase(String.valueOf(categorias.get(i).getCategoria())) == 0);
				i++;
			}
			if (existe)
				alojamientos.get(alojamientos.size() - 1).setCategoria(categorias.get(i-1));
			else {
				if(categorias.isEmpty())
				{
					categorias.add(new Categorias(0, valorAux.charAt(0)));
				}
				else
					categorias.add(new Categorias(categorias.get(categorias.size() - 1).getId() + 1, valorAux.charAt(0)));
				alojamientos.get(alojamientos.size() - 1).setCategoria(categorias.get(categorias.size() - 1));
			}
		}
		// Guarda Club
		if (localName.compareToIgnoreCase("productclub") == 0)
			alojamientos.get(alojamientos.size() - 1).setClub(valorAux.contains("1"));
		// Guarda Restaurante
		if (localName.compareToIgnoreCase("restaurant") == 0)
			alojamientos.get(alojamientos.size() - 1).setRestaurant(valorAux.contains("1"));
		// Guarda Autocaravana
		if (localName.compareToIgnoreCase("autocaravana") == 0)
			alojamientos.get(alojamientos.size() - 1).setAutocaravana(valorAux.contains("1"));
		// Guarda Tienda
		if (localName.compareToIgnoreCase("store") == 0)
			alojamientos.get(alojamientos.size() - 1).setTienda(valorAux.contains("1"));
		// Guarda capacidad
		if (localName.compareToIgnoreCase("capacity") == 0)
			alojamientos.get(alojamientos.size() - 1).setCapacidad(Integer.valueOf(valorAux));
		// Guarda Gastronómico
		if (localName.compareToIgnoreCase("gastronomical") == 0)
			alojamientos.get(alojamientos.size() - 1).setGastronomico(valorAux.contains("1"));
		// Guarda Surfing
		if (localName.compareToIgnoreCase("surfing") == 0)
			alojamientos.get(alojamientos.size() - 1).setSurfing(valorAux.contains("1"));
		// Guarda Código Postal
		if (localName.compareToIgnoreCase("postalcode") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < codigosPostales.size()) {
				existe = (valorAux.compareToIgnoreCase(String.valueOf(codigosPostales.get(i).getCodigoPostal())) == 0);
				i++;
			}
			if (existe)
				alojamientos.get(alojamientos.size() - 1).setCp(codigosPostales.get(i-1));
			else {
				if(codigosPostales.isEmpty())
					codigosPostales.add(new CodigoPostal(0, Integer.valueOf(valorAux)));
				else
					codigosPostales.add(new CodigoPostal(codigosPostales.get(codigosPostales.size() - 1).getId() + 1,
						Integer.valueOf(valorAux)));
				alojamientos.get(alojamientos.size() - 1).setCp(codigosPostales.get(codigosPostales.size() - 1));
			}
		}
		// Guarda Latitud Y Longitud
		if (localName.compareToIgnoreCase("latitudelongitude") == 0)
			alojamientos.get(alojamientos.size() - 1).setCoordenadas(valorAux);
		// Guarda Municipio
		if (localName.compareToIgnoreCase("municipality") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < municipios.size()) {
				existe = (valorAux.compareToIgnoreCase(municipios.get(i).getMunicipio()) == 0);
				i++;
			}
			if (existe)
				alojamientos.get(alojamientos.size() - 1).setMunicipio(municipios.get(i-1));
			else {
				municipios.add(new Municipio(valorAux));
				alojamientos.get(alojamientos.size() - 1).setMunicipio(municipios.get(municipios.size() - 1));
			}
		}
		// Guarda Código Municipal
		if (localName.compareToIgnoreCase("municipalitycode") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < municipios.size()) {
				existe = (valorAux.compareToIgnoreCase(String.valueOf(municipios.get(i).getCod())) == 0);
				i++;
			}
			if (!existe) {
				municipios.get(municipios.size() - 1).setCod(Integer.valueOf(valorAux));
				alojamientos.get(alojamientos.size() - 1).getMunicipio().setCod(Integer.valueOf(valorAux));
			}
		}
		// Guarda Provincia
		if (localName.compareToIgnoreCase("territory") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < provincias.size()) {
				existe = (valorAux.compareToIgnoreCase(provincias.get(i).getProvincia()) == 0);
				i++;
			}
			if (existe)
				alojamientos.get(alojamientos.size() - 1).setProvincia(provincias.get(i-1));
			else {
				provincias.add(new Provincia(valorAux));
				alojamientos.get(alojamientos.size() - 1).setProvincia(provincias.get(provincias.size() - 1));
			}
		}
		// Guarda Código Provincia
		if (localName.compareToIgnoreCase("territorycode") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < provincias.size()) {
				existe = (valorAux.compareToIgnoreCase(String.valueOf(provincias.get(i).getCod())) == 0);
				i++;
			}
			if (!existe) {
				provincias.get(provincias.size() - 1).setCod(Integer.valueOf(valorAux));
				alojamientos.get(alojamientos.size() - 1).getProvincia().setCod(Integer.valueOf(valorAux));
			}
		}
	}

	@Override
	public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
		valorAux = null;
		if (localName.compareToIgnoreCase("documentname") == 0)
			alojamientos.add(new Modelo.Alojamiento());
	}
}
