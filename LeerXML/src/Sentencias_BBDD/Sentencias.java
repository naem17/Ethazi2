package Sentencias_BBDD;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
public class Sentencias {

	protected static PreparedStatement statement = null;
	protected static ResultSet rs = null;
	static int indice=0;

	public static void consulta(String sentencia) {
		try {
			statement = Conexion.conexion.prepareStatement(sentencia);
			rs = statement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void sentenciaNoSelectiva(String sentencia) {
		try {
			statement=Conexion.conexion.prepareStatement(sentencia);
			statement.execute();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	public static void alPrimero() {
		try {
			rs.first();
			indice=rs.getRow();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void alUltimo() {
		try {
			rs.last();
			indice=rs.getRow();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void siguiente() {
		try {
			rs.last();
			if(indice<rs.getRow())
			{
				indice++;
				rs.absolute(indice);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void anterior() {
		try {
			if (indice > 1) {
				indice--;
				rs.absolute(indice);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();	
		}
	}
	public static boolean existe() {
		boolean existe=false;
		try {
			rs.beforeFirst();
			existe=rs.next();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return existe;
	}
 
	public static void cerrarStatement() {
		try {
			statement.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
