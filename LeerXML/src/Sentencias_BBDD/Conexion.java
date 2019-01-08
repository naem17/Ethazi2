package Sentencias_BBDD;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Conexion {
	public static Connection conexion = null;

	public static void conectar1(String baseDatos, String host, int port,  String login, String password) {
		String url="jdbc:mysql://"+host+":"+(port==0?"":port)+"/" + baseDatos
				+ "?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
		
		// Registrar Driver

				try {
					Class.forName("com.mysql.cj.jdbc.Driver");
				} catch (ClassNotFoundException e) {
					System.err.println("error" + "com.mysql.cj.jdbc.Driver");
					System.err.println(e.toString());
				}
		try {
			conexion = (Connection) DriverManager.getConnection(url, login, password);
			System.out.println("La conexión se ha creado de manera correcta");
		} catch (SQLException sqle) {
			System.err.println("La conexión no se ha creado");
			System.err.println(sqle.toString());
		}
	}
	public static void conectarNoAUnaBD(String host, String login, String password)
	{
		String url="jdbc:mysql://"+host+"/"
				+ "?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";

		// Registrar Driver

				try {
					Class.forName("com.mysql.cj.jdbc.Driver");
				} catch (ClassNotFoundException e) {
					System.err.println("error" + "com.mysql.cj.jdbc.Driver");
					System.err.println(e.toString());
				}
		try {
			conexion = (Connection) DriverManager.getConnection(url, login, password);
			System.out.println("La conexión se ha creado de manera correcta");
		} catch (SQLException sqle) {
			System.err.println("La conexión no se ha creado");
			System.err.println(sqle.toString());
		}
	}

	public static void cerrar1() {
		try {
			conexion.close();
		} catch (SQLException e) {
			System.err.println("No se ha podido cerrar la conexion.");
			System.err.println(e.toString());
		}
	}

}
