namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for C_CommissionLine
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_CommissionLine : PO
{
public X_C_CommissionLine (Context ctx, int C_CommissionLine_ID, Trx trxName) : base (ctx, C_CommissionLine_ID, trxName)
{
/** if (C_CommissionLine_ID == 0)
{
SetAmtMultiplier (0.0);
SetAmtSubtract (0.0);
SetC_CommissionLine_ID (0);
SetC_Commission_ID (0);
SetCommissionOrders (false);
SetIsPositiveOnly (false);
SetLine (0);	// @SQL=SELECT NVL(MAX(Line),0)+10 AS DefaultValue FROM C_CommissionLine WHERE C_Commission_ID=@C_Commission_ID@
SetQtyMultiplier (0.0);
SetQtySubtract (0.0);
}
 */
}
public X_C_CommissionLine (Ctx ctx, int C_CommissionLine_ID, Trx trxName) : base (ctx, C_CommissionLine_ID, trxName)
{
/** if (C_CommissionLine_ID == 0)
{
SetAmtMultiplier (0.0);
SetAmtSubtract (0.0);
SetC_CommissionLine_ID (0);
SetC_Commission_ID (0);
SetCommissionOrders (false);
SetIsPositiveOnly (false);
SetLine (0);	// @SQL=SELECT NVL(MAX(Line),0)+10 AS DefaultValue FROM C_CommissionLine WHERE C_Commission_ID=@C_Commission_ID@
SetQtyMultiplier (0.0);
SetQtySubtract (0.0);
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_CommissionLine (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_CommissionLine (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_CommissionLine (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_CommissionLine()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514371388L;
/** Last Updated Timestamp 7/29/2010 1:07:34 PM */
public static long updatedMS = 1280389054599L;
/** AD_Table_ID=431 */
public static int Table_ID;
 // =431;

/** TableName=C_CommissionLine */
public static String Table_Name="C_CommissionLine";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(3);
/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel()
{
return Convert.ToInt32(accessLevel.ToString());
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO(Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_C_CommissionLine[").Append(Get_ID()).Append("]");
return sb.ToString();
}
/** Set Multiplier Amount.
@param AmtMultiplier Multiplier Amount for generating commissions */
public void SetAmtMultiplier (Decimal? AmtMultiplier)
{
if (AmtMultiplier == null) throw new ArgumentException ("AmtMultiplier is mandatory.");
Set_Value ("AmtMultiplier", (Decimal?)AmtMultiplier);
}
/** Get Multiplier Amount.
@return Multiplier Amount for generating commissions */
public Decimal GetAmtMultiplier() 
{
Object bd =Get_Value("AmtMultiplier");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Subtract Amount.
@param AmtSubtract Subtract Amount for generating commissions */
public void SetAmtSubtract (Decimal? AmtSubtract)
{
if (AmtSubtract == null) throw new ArgumentException ("AmtSubtract is mandatory.");
Set_Value ("AmtSubtract", (Decimal?)AmtSubtract);
}
/** Get Subtract Amount.
@return Subtract Amount for generating commissions */
public Decimal GetAmtSubtract() 
{
Object bd =Get_Value("AmtSubtract");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Business Partner Group.
@param C_BP_Group_ID Business Partner Group */
public void SetC_BP_Group_ID (int C_BP_Group_ID)
{
if (C_BP_Group_ID <= 0) Set_Value ("C_BP_Group_ID", null);
else
Set_Value ("C_BP_Group_ID", C_BP_Group_ID);
}
/** Get Business Partner Group.
@return Business Partner Group */
public int GetC_BP_Group_ID() 
{
Object ii = Get_Value("C_BP_Group_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Business Partner.
@param C_BPartner_ID Identifies a Business Partner */
public void SetC_BPartner_ID (int C_BPartner_ID)
{
if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);
else
Set_Value ("C_BPartner_ID", C_BPartner_ID);
}
/** Get Business Partner.
@return Identifies a Business Partner */
public int GetC_BPartner_ID() 
{
Object ii = Get_Value("C_BPartner_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Commission Line.
@param C_CommissionLine_ID Commission Line */
public void SetC_CommissionLine_ID (int C_CommissionLine_ID)
{
if (C_CommissionLine_ID < 1) throw new ArgumentException ("C_CommissionLine_ID is mandatory.");
Set_ValueNoCheck ("C_CommissionLine_ID", C_CommissionLine_ID);
}
/** Get Commission Line.
@return Commission Line */
public int GetC_CommissionLine_ID() 
{
Object ii = Get_Value("C_CommissionLine_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Commission.
@param C_Commission_ID Commission */
public void SetC_Commission_ID (int C_Commission_ID)
{
if (C_Commission_ID < 1) throw new ArgumentException ("C_Commission_ID is mandatory.");
Set_ValueNoCheck ("C_Commission_ID", C_Commission_ID);
}
/** Get Commission.
@return Commission */
public int GetC_Commission_ID() 
{
Object ii = Get_Value("C_Commission_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetC_Commission_ID().ToString());
}
/** Set Sales Region.
@param C_SalesRegion_ID Sales coverage region */
public void SetC_SalesRegion_ID (int C_SalesRegion_ID)
{
if (C_SalesRegion_ID <= 0) Set_Value ("C_SalesRegion_ID", null);
else
Set_Value ("C_SalesRegion_ID", C_SalesRegion_ID);
}
/** Get Sales Region.
@return Sales coverage region */
public int GetC_SalesRegion_ID() 
{
Object ii = Get_Value("C_SalesRegion_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Commission only specified Orders.
@param CommissionOrders Commission only Orders or Invoices, where this Sales Rep is entered */
public void SetCommissionOrders (Boolean CommissionOrders)
{
Set_Value ("CommissionOrders", CommissionOrders);
}
/** Get Commission only specified Orders.
@return Commission only Orders or Invoices, where this Sales Rep is entered */
public Boolean IsCommissionOrders() 
{
Object oo = Get_Value("CommissionOrders");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description)
{
if (Description != null && Description.Length > 255)
{
log.Warning("Length > 255 - truncated");
Description = Description.Substring(0,255);
}
Set_Value ("Description", Description);
}
/** Get Description.
@return Optional short description of the record */
public String GetDescription() 
{
return (String)Get_Value("Description");
}
/** Set Positive only.
@param IsPositiveOnly Do not generate negative commissions */
public void SetIsPositiveOnly (Boolean IsPositiveOnly)
{
Set_Value ("IsPositiveOnly", IsPositiveOnly);
}
/** Get Positive only.
@return Do not generate negative commissions */
public Boolean IsPositiveOnly() 
{
Object oo = Get_Value("IsPositiveOnly");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Line No.
@param Line Unique line for this document */
public void SetLine (int Line)
{
Set_Value ("Line", Line);
}
/** Get Line No.
@return Unique line for this document */
public int GetLine() 
{
Object ii = Get_Value("Line");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Product Category.
@param M_Product_Category_ID Category of a Product */
public void SetM_Product_Category_ID (int M_Product_Category_ID)
{
if (M_Product_Category_ID <= 0) Set_Value ("M_Product_Category_ID", null);
else
Set_Value ("M_Product_Category_ID", M_Product_Category_ID);
}
/** Get Product Category.
@return Category of a Product */
public int GetM_Product_Category_ID() 
{
Object ii = Get_Value("M_Product_Category_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Product.
@param M_Product_ID Product, Service, Item */
public void SetM_Product_ID (int M_Product_ID)
{
if (M_Product_ID <= 0) Set_Value ("M_Product_ID", null);
else
Set_Value ("M_Product_ID", M_Product_ID);
}
/** Get Product.
@return Product, Service, Item */
public int GetM_Product_ID() 
{
Object ii = Get_Value("M_Product_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}

/** Org_ID AD_Reference_ID=130 */
public static int ORG_ID_AD_Reference_ID=130;
/** Set Organization.
@param Org_ID Organizational entity within client */
public void SetOrg_ID (int Org_ID)
{
if (Org_ID <= 0) Set_Value ("Org_ID", null);
else
Set_Value ("Org_ID", Org_ID);
}
/** Get Organization.
@return Organizational entity within client */
public int GetOrg_ID() 
{
Object ii = Get_Value("Org_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Multiplier Quantity.
@param QtyMultiplier Value to multiply quantities by for generating commissions. */
public void SetQtyMultiplier (Decimal? QtyMultiplier)
{
if (QtyMultiplier == null) throw new ArgumentException ("QtyMultiplier is mandatory.");
Set_Value ("QtyMultiplier", (Decimal?)QtyMultiplier);
}
/** Get Multiplier Quantity.
@return Value to multiply quantities by for generating commissions. */
public Decimal GetQtyMultiplier() 
{
Object bd =Get_Value("QtyMultiplier");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Subtract Quantity.
@param QtySubtract Quantity to subtract when generating commissions */
public void SetQtySubtract (Decimal? QtySubtract)
{
if (QtySubtract == null) throw new ArgumentException ("QtySubtract is mandatory.");
Set_Value ("QtySubtract", (Decimal?)QtySubtract);
}
/** Get Subtract Quantity.
@return Quantity to subtract when generating commissions */
public Decimal GetQtySubtract() 
{
Object bd =Get_Value("QtySubtract");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
}

}
