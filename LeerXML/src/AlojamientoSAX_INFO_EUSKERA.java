import java.util.ArrayList;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import Modelo.Alojamiento;
import Modelo.TipoAlbergueEuskera;

public class AlojamientoSAX_INFO_EUSKERA extends DefaultHandler{
	ArrayList<Modelo.Alojamiento> alojamientos;
	ArrayList<Modelo.TipoAlbergueEuskera> tiposAlbergues;
	private String valorAux;
	private Modelo.Alojamiento alojamiento;
	public AlojamientoSAX_INFO_EUSKERA(ArrayList<Modelo.Alojamiento> alojamientos, ArrayList<Modelo.TipoAlbergueEuskera> tipoAlbergueEuskeras) {

		this.alojamientos = alojamientos;
		this.tiposAlbergues = tipoAlbergueEuskeras;
		valorAux = null;
		alojamiento=new Alojamiento();
	}
	@Override
	public void endElement(String uri, String localName, String qName) throws SAXException {
		
		if(localName.compareToIgnoreCase("signatura")==0)
			alojamiento.setFirma(valorAux);
		if (localName.compareToIgnoreCase("turismdescription") == 0 && alojamiento.getDescripcionEuskera()==null)	
			alojamiento.setDescripcionEuskera(valorAux);
		
		else
			if (localName.compareToIgnoreCase("turismdescription") == 0 && alojamiento.getDescripcionNOAbreviada()==null)
			alojamiento.setDescripcionNOAbreviadaEuskera(valorAux);
		if (localName.compareToIgnoreCase("lodgingtype") == 0) {
			boolean existe = false;
			int i = 0;
			while (!existe && i < tiposAlbergues.size()) {
				existe = (valorAux.compareToIgnoreCase(tiposAlbergues.get(i).getTipoEuskera()) == 0);
				i++;
			}
			if(!existe)
			{
				if(tiposAlbergues.isEmpty())
					tiposAlbergues.add(new TipoAlbergueEuskera(0,valorAux));
				else
					tiposAlbergues.add(new TipoAlbergueEuskera(tiposAlbergues.get(tiposAlbergues.size()-1).getId()+1,valorAux));
				alojamiento.setTipoEuskera(tiposAlbergues.get(tiposAlbergues.size()-1));
			}
			else
			{
				alojamiento.setTipoEuskera(tiposAlbergues.get(i-1));
			}
			
		}
	}
	@Override
	public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
		if(alojamiento.getFirma()!=null &&
				alojamiento.getDescripcionEuskera()!=null &&
				alojamiento.getDescripcionNOAbreviadaEuskera()!=null &&
				alojamiento.getTipoEuskera()!=null)
		{
			int i=0;
			while(i<alojamientos.size() && !alojamientos.get(i).equals(alojamiento))
				i++;
			if(i<alojamientos.size())
			{
				alojamientos.get(i).setDescripcionEuskera(alojamiento.getDescripcionEuskera());
				alojamientos.get(i).setDescripcionNOAbreviadaEuskera(alojamiento.getDescripcionNOAbreviadaEuskera());
				alojamientos.get(i).setTipoEuskera(alojamiento.getTipoEuskera());
			}
			alojamiento.setFirma(null);
			alojamiento.setDescripcionEuskera(null);
			alojamiento.setDescripcionNOAbreviadaEuskera(null);
			alojamiento.setTipoEuskera(null);
		}	
	}
	@Override
	public void characters(char[] ch, int start, int length) throws SAXException {
		
		valorAux = String.valueOf(ch).substring(start, start+length);
	}
	

}
