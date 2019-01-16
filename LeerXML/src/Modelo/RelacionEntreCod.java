package Modelo;

public class RelacionEntreCod {
	

	private int codigoMunicipio;
	private int codigoProvincia;
	private int codigoPostal;
	private int id;
	

	public RelacionEntreCod(int codigoMunicipio, int codigoProvincia, int iDCodigoPostal) {
		super();
		this.codigoMunicipio = codigoMunicipio;
		this.codigoProvincia = codigoProvincia;
		this.codigoPostal = iDCodigoPostal;
	}

	public RelacionEntreCod() {
		super();
		this.codigoMunicipio=0;
		this.codigoPostal=0;
		this.codigoProvincia=0;
	}
	
	public int getCodigoMunicipio() {
		return codigoMunicipio;
	}

	public void setCodigoMunicipio(int codigoMunicipio) {
		this.codigoMunicipio = codigoMunicipio;
	}

	public int getCodigoProvincia() {
		return codigoProvincia;
	}

	public void setCodigoProvincia(int codigoProvincia) {
		this.codigoProvincia = codigoProvincia;
	}

	public int getiDCodigoPostal() {
		return codigoPostal;
	}

	public void setiDCodigoPostal(int iDCodigoPostal) {
		this.codigoPostal = iDCodigoPostal;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	@Override
	public boolean equals(Object arg0) {
		RelacionEntreCod aux= ((RelacionEntreCod) arg0);
		return arg0 instanceof RelacionEntreCod && this.codigoMunicipio==aux.getCodigoMunicipio() && this.codigoProvincia==aux.getCodigoProvincia() && this.codigoPostal==aux.getiDCodigoPostal();
	}

	

}
