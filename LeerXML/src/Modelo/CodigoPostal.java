package Modelo;

public class CodigoPostal {
	private int codigoPostal; //CODIGO_POSTAL NUMERIC(5)
	public CodigoPostal() {
		super();
	}
	
	public CodigoPostal(int codigoPostal) {
		super();
		this.codigoPostal = codigoPostal;
	}
	public int getCodigoPostal() {
		return codigoPostal;
	}
	public void setCodigoPostal(int codigoPostal) {
		this.codigoPostal = codigoPostal;
	}

	@Override
	public boolean equals(Object obj) {
		return obj instanceof CodigoPostal &&( (CodigoPostal)obj).getCodigoPostal()==this.codigoPostal;
	}
	
}
