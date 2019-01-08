package Modelo;


public class Categorias {
	private int id; //ID AUTONUMERICO
	private char categoria; //CATEGORIA VHARCHJAR(20)
	public Categorias() {
		super();
	}
	
	public Categorias(int id, char categoria) {
		super();
		this.id = id;
		this.categoria = categoria;
	}

	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public char getCategoria() {
		return categoria;
	}
	public void setCategoria(char categoria) {
		this.categoria = categoria;
	}
	@Override
	public String toString() {
		return "Categorias [id=" + id + ", categoria=" + categoria + "]";
	}
	
	

}
