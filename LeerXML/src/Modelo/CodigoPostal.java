package Modelo;

public class CodigoPostal {
	private int id; //ID AUTONUMERICO
	private int codigoPostal; //CODIGO_POSTAL NUMERIC(5)
	public CodigoPostal() {
		super();
	}
	
	public CodigoPostal(int id, int codigoPostal) {
		super();
		this.id = id;
		this.codigoPostal = codigoPostal;
	}

	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getCodigoPostal() {
		return codigoPostal;
	}
	public void setCodigoPostal(int codigoPostal) {
		this.codigoPostal = codigoPostal;
	}
	@Override
	public String toString() {
		return "CodigoPostal [id=" + id + ", codigoPostal=" + codigoPostal + "]";
	}
	
	

}
