package Sentencias_BBDD;

import java.sql.SQLException;

public class Sentencias_BBDD_Alojamientos extends Sentencias {
	
	public static void insertarMunicipios(int indice, int codigo, String municipio)
	{
		try {
			statement=Conexion.conexion.prepareStatement("INSERT INTO MUNICIPIOS VALUES("
					+ "?,?,?"
					+ ");");
			statement.setInt(1, codigo);
			statement.setString(2, municipio);
			statement.setInt(3, indice);
			statement.execute();
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
				
	}
	public static void insertarEnTablaIDString(String tabla, int codigo, String info)
	{
		try {
			statement=Conexion.conexion.prepareStatement("INSERT INTO "+tabla+" VALUES("
					+ "?,?"
					+ ");");
			statement.setInt(1, codigo);
			statement.setString(2, info);
			statement.execute();
			
		} catch (SQLException e) {
			e.printStackTrace();
		}	
	}
	public static void insertarCodigos_Postales(int id, int codigoPostal)
	{
		try {
			statement=Conexion.conexion.prepareStatement("INSERT INTO CODIGOS_POSTALES VALUES("
					+ "?,?"
					+ ");");
			statement.setInt(1, id);
			statement.setInt(2, codigoPostal);
			statement.execute();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	public static void insertarAlojamiento( String firma, String nombre, String desc_Abreviada, String desc_Abreviada_Euskera, 
			String desc, String desc_Esukera, String tel,String direccion,
			boolean calidad_Asegurada, String email, String web, 
			boolean club, boolean restaurante, boolean autocaravana,
			boolean tienda, int capacidad, boolean gastronomico, 
			boolean surfing,String coordenadas, int codMunicipio,
			int codProvincia, int codTipos, int codTiposEuskera, int codCategorias, int idCP) {
		try {
			statement=Conexion.conexion.prepareStatement("INSERT INTO ALOJAMIENTOS VALUES("
					+ "?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?, ?"
					+ ",?,?,?"
					+ ");");
			statement.setString(1, firma);
			statement.setString(2, nombre);
			statement.setString(3, desc_Abreviada);
			statement.setString(4, desc_Abreviada_Euskera);
			statement.setString(5, desc);
			statement.setString(6, desc_Esukera);
			statement.setString(7, tel);
			statement.setString(8, direccion);
			statement.setBoolean(9, calidad_Asegurada);
			statement.setString(10, email);
			statement.setString(11, web);
			statement.setBoolean(12, club);
			statement.setBoolean(13, restaurante);
			statement.setBoolean(14, autocaravana);
			statement.setBoolean(15, tienda);
			statement.setInt(16, capacidad);
			statement.setBoolean(17, gastronomico);
			statement.setBoolean(18, surfing);
			statement.setString(19, coordenadas);
			statement.setInt(20, codMunicipio);
			statement.setInt(21, codProvincia);
			statement.setInt(22, codTipos);
			statement.setInt(23, codTiposEuskera);
			statement.setInt(24, codCategorias);
			statement.setInt(25, idCP);
			statement.execute();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	

}
