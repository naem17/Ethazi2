package Modelo;

public class Usuarios {
	private String nombre_usuario;
	private String contrasenia;
	private String nombre;
	private String apellidos;
	private String email;
	private String telefono;
	private char perfil;
	public Usuarios() {
		super();
	}
	public String getNombre_usuario() {
		return nombre_usuario;
	}
	public void setNombre_usuario(String nombre_usuario) {
		this.nombre_usuario = nombre_usuario;
	}
	public String getContrasenia() {
		return contrasenia;
	}
	public void setContrasenia(String contrasenia) {
		this.contrasenia = contrasenia;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getApellidos() {
		return apellidos;
	}
	public void setApellidos(String apellidos) {
		this.apellidos = apellidos;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}
	public char getPerfil() {
		return perfil;
	}
	public void setPerfil(char perfil) {
		this.perfil = perfil;
	}
	@Override
	public String toString() {
		return "Usuarios [nombre_usuario=" + nombre_usuario + ", contrasenia=" + contrasenia + ", nombre=" + nombre
				+ ", apellidos=" + apellidos + ", email=" + email + ", telefono=" + telefono + ", perfil=" + perfil
				+ "]";
	}
	
	
}
