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

	// defined in */scripts/entity_defs/Account.def
	public class EntityBaseEntityCall_AccountBase : EntityCall
	{

		public EntityBaseEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void reqBuyKabao(Int32 arg1)
		{
			Bundle pBundle = newCall("reqBuyKabao", 0);
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			sendCall(null);
		}

		public void reqCardList()
		{
			Bundle pBundle = newCall("reqCardList", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqChangeLevel(Int16 arg1)
		{
			Bundle pBundle = newCall("reqChangeLevel", 0);
			if(pBundle == null)
				return;

			bundle.writeInt16(arg1);
			sendCall(null);
		}

		public void reqChangeName(string arg1)
		{
			Bundle pBundle = newCall("reqChangeName", 0);
			if(pBundle == null)
				return;

			bundle.writeUnicode(arg1);
			sendCall(null);
		}

		public void reqDelCardGroup(SByte arg1)
		{
			Bundle pBundle = newCall("reqDelCardGroup", 0);
			if(pBundle == null)
				return;

			bundle.writeInt8(arg1);
			sendCall(null);
		}

		public void reqEditCardGroup(CARDGROUP_INFO arg1)
		{
			Bundle pBundle = newCall("reqEditCardGroup", 0);
			if(pBundle == null)
				return;

			((DATATYPE_CARDGROUP_INFO)EntityDef.id2datatypes[25]).addToStreamEx(bundle, arg1);
			sendCall(null);
		}

		public void reqOpenKabao()
		{
			Bundle pBundle = newCall("reqOpenKabao", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_AccountBase : EntityCall
	{

		public EntityCellEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

	}
	}
