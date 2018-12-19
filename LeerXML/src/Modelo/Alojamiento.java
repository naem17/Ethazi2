package Modelo;

import javax.persistence.Entity;
import javax.persistence.Table;

@Entity
@Table(name= "ALOJAMIENTOS")
public class Alojamiento {
	private String firma; //FIRMA VARCHAR(8)
	private String nombre; //NOMBRE VARCHAR(50)
	private String descripcionAbreviada; //DESCRIPCION_ABREVIADA VARCHAR(100) 
	private String descripcionEuskera; //DESCRIPCION_ABREVIADA_EUSKERA VARCHAR(100)
	private String descripcionNOAbreviada; //DESCRIPCION_NO_ABREVIADA VARCHAR(1500)
	private String descripcionNOAbreviadaEuskera; //DESCRIPCION_NO_ABREVIADA_EUSKERA VARCHAR(1500)
	private String telefono; //TELEFONO VARCHAR(15)
	private String direccion; //DIRECCION VARCHAR(100)
	private boolean calidadAsegurada; //CALIDAD_ASEGURADA BOOLEAN
	private String email; //EMAIL VARCHAR(20)
	private String webURL; //WEB VARCHAR(200)
	private boolean club; //CLUB BOOLEAN
	private boolean restaurant; //RESTAURANTE BOOLEAN
	private boolean autocaravana; //AUTOCARAVANA BOOLEAN
	private boolean tienda; //TIENDA BOOLEAN
	private int capacidad; //CAPACIDAD NUMERIC(4)
	private boolean gastronomico; //GASTRONOMICO BOOLEAN
	private boolean surfing; //SURFING BOOLEAN
	private String coordenadas; //COORDENADAS VARCHAR(200)
	
	//Claves foráneas
	private TipoAlbergue tipo;
	private TipoAlbergueEuskera tipoEuskera;
	private Categorias categoria;
	private Municipio municipio;
	private Provincia provincia;
	private CodigoPostal cp;
	
	public Alojamiento()
	{
		calidadAsegurada=false;
		club=false;
		restaurant=false;
		autocaravana=false;
		tienda=false;
		gastronomico=false;
		surfing=false;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getDescripcionAbreviada() {
		return descripcionAbreviada;
	}
	public void setDescripcionAbreviada(String descripcionAbreviada) {
		this.descripcionAbreviada = descripcionAbreviada;
	}
	public String getDescripcionNOAbreviada() {
		return descripcionNOAbreviada;
	}
	public void setDescripcionNOAbreviada(String descripcionNOAbreviada) {
		this.descripcionNOAbreviada = descripcionNOAbreviada;
	}

	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}
	public String getDireccion() {
		return direccion;
	}
	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}
	public boolean isCalidadAsegurada() {
		return calidadAsegurada;
	}
	public void setCalidadAsegurada(boolean calidadAsegurada) {
		this.calidadAsegurada = calidadAsegurada;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getWebURL() {
		return webURL;
	}
	public void setWebURL(String webURL) {
		this.webURL = webURL;
	}
	
	
	public String getCoordenadas() {
		return coordenadas;
	}
	public void setCoordenadas(String coordenadas) {
		this.coordenadas = coordenadas;
	}
	public boolean isClub() {
		return club;
	}
	public void setClub(boolean club) {
		this.club = club;
	}
	public boolean isRestaurant() {
		return restaurant;
	}
	public void setRestaurant(boolean restaurant) {
		this.restaurant = restaurant;
	}
	public boolean isAutocaravana() {
		return autocaravana;
	}
	public void setAutocaravana(boolean autocaravana) {
		this.autocaravana = autocaravana;
	}
	public boolean isTienda() {
		return tienda;
	}
	public void setTienda(boolean tienda) {
		this.tienda = tienda;
	}
	public int getCapacidad() {
		return capacidad;
	}
	public void setCapacidad(int capacidad) {
		this.capacidad = capacidad;
	}
	public boolean isGastronomico() {
		return gastronomico;
	}
	public void setGastronomico(boolean gastronomico) {
		this.gastronomico = gastronomico;
	}
	public boolean isSurfing() {
		return surfing;
	}
	public void setSurfing(boolean surfing) {
		this.surfing = surfing;
	}
	
	
	public TipoAlbergue getTipo() {
		return tipo;
	}
	public void setTipo(TipoAlbergue tipo) {
		this.tipo = tipo;
	}
	public Categorias getCategoria() {
		return categoria;
	}
	public void setCategoria(Categorias categoria) {
		this.categoria = categoria;
	}
	public Municipio getMunicipio() {
		return municipio;
	}
	public void setMunicipio(Municipio municipio) {
		this.municipio = municipio;
	}
	public Provincia getProvincia() {
		return provincia;
	}
	public void setProvincia(Provincia provincia) {
		this.provincia = provincia;
	}
	public CodigoPostal getCp() {
		return cp;
	}
	public void setCp(CodigoPostal cp) {
		this.cp = cp;
	}
	

	
	public String getDescripcionEuskera() {
		return descripcionEuskera;
	}
	public void setDescripcionEuskera(String descripcionEuskera) {
		this.descripcionEuskera = descripcionEuskera;
	}
	public String getDescripcionNOAbreviadaEuskera() {
		return descripcionNOAbreviadaEuskera;
	}
	public void setDescripcionNOAbreviadaEuskera(String descripcionNOAbreviadaEuskera) {
		this.descripcionNOAbreviadaEuskera = descripcionNOAbreviadaEuskera;
	}
	
	public String getFirma() {
		return firma;
	}
	public void setFirma(String firma) {
		this.firma = firma;
	}
	public TipoAlbergueEuskera getTipoEuskera() {
		return tipoEuskera;
	}
	public void setTipoEuskera(TipoAlbergueEuskera tipoEuskera) {
		this.tipoEuskera = tipoEuskera;
	}
	
	@Override
	public boolean equals(Object obj) {
		return this.firma.compareToIgnoreCase(((Alojamiento)obj).getFirma())==0;
	}
	@Override
	public String toString() {
		return "Alojamiento [firma=" + firma + ", nombre=" + nombre + ", descripcionAbreviada=" + descripcionAbreviada
				+ ", descripcionEuskera=" + descripcionEuskera + ", descripcionNOAbreviada=" + descripcionNOAbreviada
				+ ", descripcionNOAbreviadaEuskera=" + descripcionNOAbreviadaEuskera + ", telefono=" + telefono
				+ ", direccion=" + direccion + ", calidadAsegurada=" + calidadAsegurada + ", email=" + email
				+ ", webURL=" + webURL + ", club=" + club + ", restaurant=" + restaurant + ", autocaravana="
				+ autocaravana + ", tienda=" + tienda + ", capacidad=" + capacidad + ", gastronomico=" + gastronomico
				+ ", surfing=" + surfing + ", coordenadas=" + coordenadas + ", tipo=" + tipo + ", tipoEuskera="
				+ tipoEuskera + ", categoria=" + categoria + ", municipio=" + municipio + ", provincia=" + provincia
				+ ", cp=" + cp + "]";
	}
	
}
