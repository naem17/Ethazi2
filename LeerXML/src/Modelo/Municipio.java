package Modelo;

public class Municipio {
	private int cod; //CODIGO NUMERIC(3)
	private String municipio; //MUNICIPIO VARCHAR(50)
	private int indice; //INDICE NUMERIC(4)
	
	public Municipio() {
		super();
	}
	
	public Municipio(int cod, String municipio) {
		super();
		this.cod = cod;
		this.municipio = municipio;
	}
	

	public Municipio(int cod, String municipio, int indice) {
		super();
		this.cod = cod;
		this.municipio = municipio;
		this.indice = indice;
	}

	public Municipio(String municipio) {
		super();
		this.municipio = municipio;
		this.cod=-1;
		this.indice=-1;
	}

	
	public int getIndice() {
		return indice;
	}

	public void setIndice(int indice) {
		this.indice = indice;
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

	@Override
	public boolean equals(Object obj) {
		return obj instanceof Municipio && ((Municipio)obj).getCod()==this.cod && ((Municipio)obj).getMunicipio().compareToIgnoreCase(this.municipio)==0;
	}
	
	

}
