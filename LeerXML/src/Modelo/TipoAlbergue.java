package Modelo;

public class TipoAlbergue {
	private int id; //CODIGO AUTONUMERICO
	private String tipo; // TIPO VARCHAR(20)
	
	public TipoAlbergue() {
		super();
	}
	
	public TipoAlbergue(int id, String tipo) {
		super();
		this.id = id;
		this.tipo = tipo;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	@Override
	public String toString() {
		return "TipoAlbergue [id=" + id + ", tipo=" + tipo + "]";
	}
	
	

}
