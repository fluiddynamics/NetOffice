//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary DAO 6, 12, 
	 /// </summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum CursorDriverEnum
	{
		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		/// <remarks>-1</remarks>
		[SupportByLibrary("DAO", 6,12)]
		 dbUseDefaultCursor = -1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		/// <remarks>1</remarks>
		[SupportByLibrary("DAO", 6,12)]
		 dbUseODBCCursor = 1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		/// <remarks>2</remarks>
		[SupportByLibrary("DAO", 6,12)]
		 dbUseServerCursor = 2,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		/// <remarks>3</remarks>
		[SupportByLibrary("DAO", 6,12)]
		 dbUseClientBatchCursor = 3,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		/// <remarks>4</remarks>
		[SupportByLibrary("DAO", 6,12)]
		 dbUseNoCursor = 4
	}
}