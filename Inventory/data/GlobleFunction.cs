////using System;
//
//namespace Inventory
//{
//	public class GlobalFunctions
//	{
//
//
//		public GlobalFunctions ()
//		{
//		}
//
//		public static void AddData()
//		{
//			//GlobalVariables.Employee.Clear ();
//
//			for (int i = 0; i < 5; i++) {
//				DimUser E = new DimUser ();
//				//E.index = i;
//				E.UserId = "Name " + i;
//				E.Password = "password".ToString();
//
//
//				//	GlobalVariables.Employee.Add (E);
//				sqllitedatabase objDatabase = new sqllitedatabase();
//				objDatabase.SaveEmp (E);
//			}
//		}
//
////		public static DimUser GetDataByIndex(int index)
////		{
////			return GlobalVariables.Employee [index];
////		}
////
////		public static void UpdateData(int index,Employee e)
////		{
////			SQLiteDatabase objDatabase = new SQLiteDatabase();
////			//GlobalVariables.Employee [index] = e;
////			objDatabase.SaveEmp (e);
////		}
//	}
//}
