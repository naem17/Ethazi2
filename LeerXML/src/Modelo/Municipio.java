package Modelo;

public class Municipio {
	private int cod; //CODIGO NUMERIC(3)
	private String municipio; //MUNICIPIO VARCHAR(50)
	public Municipio() {
		super();
	}
	
	public Municipio(int cod, String municipio) {
		super();
		this.cod = cod;
		this.municipio = municipio;
	}
	

	public Municipio(String municipio) {
		super();
		this.municipio = municipio;
	}

	public int getCod() {
		return cod;
	}
	public void setCod(int cod) {
		this.cod = cod;
	}
	public String getMunicipio() {
		return municipio;
	}
	public void setMunicipio(String municipio) {
		this.municipio = municipio;
	}
	@Override
	public String toString() {
		return "Municipio [cod=" + cod + ", municipio=" + municipio + "]";
	}
	
	

}
