//using System;
//using SQLite;
//using System.Collections.Generic;
//using System.Linq;
//using Xamarin.Forms;
//
//namespace Inventory
//{
//	public class sqllitedatabase
//	{
//		static object locker = new object ();
//		SQLiteConnection database;
//
//		public sqllitedatabase ()
//		{
//			database = DependencyService.Get<Isqlite> ().GetConnection ();
//
//			database.CreateTable<DimUser> ();
//		}
//
//		public IEnumerable<DimUser> GetEmps ()
//		{
//			lock (locker) {
//				return (from i in database.Table<DimUser>() select i).ToList();
//			}
//		}
//
//
//
//		public DimUser GetEmp (int id) 
//		{
//			lock (locker) {
//				return database.Table<DimUser>().FirstOrDefault(x => x.index == id);
//			}
//		}
//
//		public int SaveEmp (DimUser Emp) 
//		{
//			lock (locker) {
//				if (Emp.index != 0) {
//					database.Update(Emp);
//					return Emp.index;
//				} else {
//					return database.Insert(Emp);
//				}
//			}
//		}
//
//		public int DeleteEmp(int id)
//		{
//			lock (locker) {
//				return database.Delete<DimUser>(id);
//			}
//		}
//	}
//}
//
