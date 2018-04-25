/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;



	public class DATATYPE_CARD_INFO : DATATYPE_BASE
	{
		public CARD_INFO createFromStreamEx(MemoryStream stream)
		{
			CARD_INFO datas = new CARD_INFO();
			datas.CardID = stream.readUint64();
			datas.CardNum = stream.readUint8();
			return datas;
		}

		public void addToStreamEx(Bundle stream, CARD_INFO v)
		{
			stream.writeUint64(v.CardID);
			stream.writeUint8(v.CardNum);
		}
	}



	public class DATATYPE_OPEN_PACK_RUL : DATATYPE_BASE
	{
		public OPEN_PACK_RUL createFromStreamEx(MemoryStream stream)
		{
			UInt32 size = stream.readUint32();
			OPEN_PACK_RUL datas = new OPEN_PACK_RUL();

			while(size > 0)
			{
				--size;
				datas.Add(stream.readUint64());
			};

			return datas;
		}

		public void addToStreamEx(Bundle stream, OPEN_PACK_RUL v)
		{
			stream.writeUint32((UInt32)v.Count);
			for(int i=0; i<v.Count; ++i)
			{
				stream.writeUint64(v[i]);
			};
		}
	}



	public class DATATYPE_CARD_LIST : DATATYPE_BASE
	{
		private DATATYPE_CARD_INFO itemType = new DATATYPE_CARD_INFO();

		public CARD_LIST createFromStreamEx(MemoryStream stream)
		{
			UInt32 size = stream.readUint32();
			CARD_LIST datas = new CARD_LIST();

			while(size > 0)
			{
				--size;
				datas.Add(itemType.createFromStreamEx(stream));
			};

			return datas;
		}

		public void addToStreamEx(Bundle stream, CARD_LIST v)
		{
			stream.writeUint32((UInt32)v.Count);
			for(int i=0; i<v.Count; ++i)
			{
				itemType.addToStream(stream, v[i]);
			};
		}
	}



	public class DATATYPE_CARDGROUP_INFO : DATATYPE_BASE
	{
		private DATATYPE_CARD_LIST_ChildArray CardList_DataType = new DATATYPE_CARD_LIST_ChildArray();

		public class DATATYPE_CARD_LIST_ChildArray : DATATYPE_BASE
		{
			private DATATYPE_CARD_INFO itemType = new DATATYPE_CARD_INFO();

			public CARD_LIST createFromStreamEx(MemoryStream stream)
			{
				UInt32 size = stream.readUint32();
				CARD_LIST datas = new CARD_LIST();

				while(size > 0)
				{
					--size;
					datas.Add(itemType.createFromStreamEx(stream));
				};

				return datas;
			}

			public void addToStreamEx(Bundle stream, CARD_LIST v)
			{
				stream.writeUint32((UInt32)v.Count);
				for(int i=0; i<v.Count; ++i)
				{
					itemType.addToStream(stream, v[i]);
				};
			}
		}

		public CARDGROUP_INFO createFromStreamEx(MemoryStream stream)
		{
			CARDGROUP_INFO datas = new CARDGROUP_INFO();
			datas.Name = stream.readUnicode();
			datas.RoleType = stream.readUint8();
			datas.CardList = CardList_DataType.createFromStreamEx(stream);
			return datas;
		}

		public void addToStreamEx(Bundle stream, CARDGROUP_INFO v)
		{
			stream.writeUnicode(v.Name);
			stream.writeUint8(v.RoleType);
			CardList_DataType.addToStreamEx(stream, v.CardList);
		}
	}



	public class DATATYPE_CARDGROUP_INFO_LIST : DATATYPE_BASE
	{
		private DATATYPE_CARDGROUP_INFO itemType = new DATATYPE_CARDGROUP_INFO();

		public CARDGROUP_INFO_LIST createFromStreamEx(MemoryStream stream)
		{
			UInt32 size = stream.readUint32();
			CARDGROUP_INFO_LIST datas = new CARDGROUP_INFO_LIST();

			while(size > 0)
			{
				--size;
				datas.Add(itemType.createFromStreamEx(stream));
			};

			return datas;
		}

		public void addToStreamEx(Bundle stream, CARDGROUP_INFO_LIST v)
		{
			stream.writeUint32((UInt32)v.Count);
			for(int i=0; i<v.Count; ++i)
			{
				itemType.addToStream(stream, v[i]);
			};
		}
	}


}