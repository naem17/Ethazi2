package Modelo;

public class Provincia {
	private int cod; //CODIGO NUMERIC(2)
	private String provincia; //PROVINCIA VARCHAR(50)
	public Provincia() {
		super();
	}
	
	public Provincia(int cod, String provincia) {
		super();
		this.cod = cod;
		this.provincia = provincia;
	}
	public Provincia(String provincia) {
		super();
		this.provincia = provincia;
	}

	public int getCod() {
		return cod;
	}
	public void setCod(int cod) {
		this.cod = cod;
	}
	public String getProvincia() {
		return provincia;
	}
	public void setProvincia(String provincia) {
		this.provincia = provincia;
	}
	@Override
	public String toString() {
		return "Provincia [cod=" + cod + ", provincia=" + provincia + "]";
	}
	

}
