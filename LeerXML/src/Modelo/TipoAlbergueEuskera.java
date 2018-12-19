package Modelo;

public class TipoAlbergueEuskera {
	
	private int id; //CODIGO AUTONUMERICO
	private String tipoEuskera; //TIPO_EUSKERA VARCHAR(20)
	
	
	public TipoAlbergueEuskera() {
		super();
	}


	public TipoAlbergueEuskera(int id, String tipoEuskera) {
		super();
		this.id = id;
		this.tipoEuskera = tipoEuskera;
	}


	public int getId() {
		return id;
	}


	public void setId(int id) {
		this.id = id;
	}


	public String getTipoEuskera() {
		return tipoEuskera;
	}


	public void setTipoEuskera(String tipoEuskera) {
		this.tipoEuskera = tipoEuskera;
	}


	@Override
	public String toString() {
		return "TipoAlbergueEuskera [id=" + id + ", tipoEuskera=" + tipoEuskera + "]";
	}
	
	
	

}
