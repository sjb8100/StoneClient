/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Account : AccountBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	// Please inherit and implement "class Account : AccountBase"
	public abstract class AccountBase : Entity
	{
		public EntityBaseEntityCall_AccountBase baseEntityCall = null;
		public EntityCellEntityCall_AccountBase cellEntityCall = null;

		public CARDGROUP_INFO_LIST CardGroupList = new CARDGROUP_INFO_LIST();
		public virtual void onCardGroupListChanged(CARDGROUP_INFO_LIST oldValue) {}
		public CARD_LIST CardList = new CARD_LIST();
		public virtual void onCardListChanged(CARD_LIST oldValue) {}
		public Int32 Gold = 0;
		public virtual void onGoldChanged(Int32 oldValue) {}
		public Int32 Kabao = 0;
		public virtual void onKabaoChanged(Int32 oldValue) {}
		public Int16 Level = 0;
		public virtual void onLevelChanged(Int16 oldValue) {}
		public string Name = "";
		public virtual void onNameChanged(string oldValue) {}

		public abstract void onOpenPack(OPEN_PACK_RUL arg1); 
		public abstract void onReqCardList(CARD_LIST arg1, CARDGROUP_INFO_LIST arg2); 

		public AccountBase()
		{
		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_AccountBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_AccountBase(id, className);
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void onRemoteMethodCall(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];

			UInt16 methodUtype = 0;
			UInt16 componentPropertyUType = 0;

			if(sm.useMethodDescrAlias)
			{
				componentPropertyUType = stream.readUint8();
				methodUtype = stream.readUint8();
			}
			else
			{
				componentPropertyUType = stream.readUint16();
				methodUtype = stream.readUint16();
			}

			Method method = null;

			if(componentPropertyUType == 0)
			{
				method = sm.idmethods[methodUtype];
			}
			else
			{
				Property pComponentPropertyDescription = sm.idpropertys[componentPropertyUType];
				switch(pComponentPropertyDescription.properUtype)
				{
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				case 8:
					OPEN_PACK_RUL onOpenPack_arg1 = ((DATATYPE_OPEN_PACK_RUL)method.args[0]).createFromStreamEx(stream);
					onOpenPack(onOpenPack_arg1);
					break;
				case 9:
					CARD_LIST onReqCardList_arg1 = ((DATATYPE_CARD_LIST)method.args[0]).createFromStreamEx(stream);
					CARDGROUP_INFO_LIST onReqCardList_arg2 = ((DATATYPE_CARDGROUP_INFO_LIST)method.args[1]).createFromStreamEx(stream);
					onReqCardList(onReqCardList_arg1, onReqCardList_arg2);
					break;
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			while(stream.length() > 0)
			{
				UInt16 _t_utype = 0;
				UInt16 _t_child_utype = 0;

				{
					if(sm.usePropertyDescrAlias)
					{
						_t_utype = stream.readUint8();
						_t_child_utype = stream.readUint8();
					}
					else
					{
						_t_utype = stream.readUint16();
						_t_child_utype = stream.readUint16();
					}
				}

				Property prop = null;

				if(_t_utype == 0)
				{
					prop = pdatas[_t_child_utype];
				}
				else
				{
					Property pComponentPropertyDescription = pdatas[_t_utype];
					switch(pComponentPropertyDescription.properUtype)
					{
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 6:
						CARDGROUP_INFO_LIST oldval_CardGroupList = CardGroupList;
						CardGroupList = ((DATATYPE_CARDGROUP_INFO_LIST)EntityDef.id2datatypes[26]).createFromStreamEx(stream);

						if(prop.isBase())
						{
							if(inited)
								onCardGroupListChanged(oldval_CardGroupList);
						}
						else
						{
							if(inWorld)
								onCardGroupListChanged(oldval_CardGroupList);
						}

						break;
					case 5:
						CARD_LIST oldval_CardList = CardList;
						CardList = ((DATATYPE_CARD_LIST)EntityDef.id2datatypes[24]).createFromStreamEx(stream);

						if(prop.isBase())
						{
							if(inited)
								onCardListChanged(oldval_CardList);
						}
						else
						{
							if(inWorld)
								onCardListChanged(oldval_CardList);
						}

						break;
					case 3:
						Int32 oldval_Gold = Gold;
						Gold = stream.readInt32();

						if(prop.isBase())
						{
							if(inited)
								onGoldChanged(oldval_Gold);
						}
						else
						{
							if(inWorld)
								onGoldChanged(oldval_Gold);
						}

						break;
					case 4:
						Int32 oldval_Kabao = Kabao;
						Kabao = stream.readInt32();

						if(prop.isBase())
						{
							if(inited)
								onKabaoChanged(oldval_Kabao);
						}
						else
						{
							if(inWorld)
								onKabaoChanged(oldval_Kabao);
						}

						break;
					case 2:
						Int16 oldval_Level = Level;
						Level = stream.readInt16();

						if(prop.isBase())
						{
							if(inited)
								onLevelChanged(oldval_Level);
						}
						else
						{
							if(inWorld)
								onLevelChanged(oldval_Level);
						}

						break;
					case 1:
						string oldval_Name = Name;
						Name = stream.readUnicode();

						if(prop.isBase())
						{
							if(inited)
								onNameChanged(oldval_Name);
						}
						else
						{
							if(inWorld)
								onNameChanged(oldval_Name);
						}

						break;
					case 40001:
						Vector3 oldval_direction = direction;
						direction = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onDirectionChanged(oldval_direction);
						}
						else
						{
							if(inWorld)
								onDirectionChanged(oldval_direction);
						}

						break;
					case 40000:
						Vector3 oldval_position = position;
						position = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onPositionChanged(oldval_position);
						}
						else
						{
							if(inWorld)
								onPositionChanged(oldval_position);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			CARDGROUP_INFO_LIST oldval_CardGroupList = CardGroupList;
			Property prop_CardGroupList = pdatas[4];
			if(prop_CardGroupList.isBase())
			{
				if(inited && !inWorld)
					onCardGroupListChanged(oldval_CardGroupList);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CardGroupList.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCardGroupListChanged(oldval_CardGroupList);
					}
				}
			}

			CARD_LIST oldval_CardList = CardList;
			Property prop_CardList = pdatas[5];
			if(prop_CardList.isBase())
			{
				if(inited && !inWorld)
					onCardListChanged(oldval_CardList);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CardList.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCardListChanged(oldval_CardList);
					}
				}
			}

			Int32 oldval_Gold = Gold;
			Property prop_Gold = pdatas[6];
			if(prop_Gold.isBase())
			{
				if(inited && !inWorld)
					onGoldChanged(oldval_Gold);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Gold.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onGoldChanged(oldval_Gold);
					}
				}
			}

			Int32 oldval_Kabao = Kabao;
			Property prop_Kabao = pdatas[7];
			if(prop_Kabao.isBase())
			{
				if(inited && !inWorld)
					onKabaoChanged(oldval_Kabao);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Kabao.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onKabaoChanged(oldval_Kabao);
					}
				}
			}

			Int16 oldval_Level = Level;
			Property prop_Level = pdatas[8];
			if(prop_Level.isBase())
			{
				if(inited && !inWorld)
					onLevelChanged(oldval_Level);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Level.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onLevelChanged(oldval_Level);
					}
				}
			}

			string oldval_Name = Name;
			Property prop_Name = pdatas[9];
			if(prop_Name.isBase())
			{
				if(inited && !inWorld)
					onNameChanged(oldval_Name);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Name.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onNameChanged(oldval_Name);
					}
				}
			}

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[2];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[1];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

		}
	}
}