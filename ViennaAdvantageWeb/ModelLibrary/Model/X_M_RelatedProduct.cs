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
/** Generated Model for M_RelatedProduct
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_M_RelatedProduct : PO
{
public X_M_RelatedProduct (Context ctx, int M_RelatedProduct_ID, Trx trxName) : base (ctx, M_RelatedProduct_ID, trxName)
{
/** if (M_RelatedProduct_ID == 0)
{
SetM_Product_ID (0);
SetName (null);
SetRelatedProductType (null);
SetRelatedProduct_ID (0);
}
 */
}
public X_M_RelatedProduct (Ctx ctx, int M_RelatedProduct_ID, Trx trxName) : base (ctx, M_RelatedProduct_ID, trxName)
{
/** if (M_RelatedProduct_ID == 0)
{
SetM_Product_ID (0);
SetName (null);
SetRelatedProductType (null);
SetRelatedProduct_ID (0);
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RelatedProduct (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RelatedProduct (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RelatedProduct (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_M_RelatedProduct()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514381074L;
/** Last Updated Timestamp 7/29/2010 1:07:44 PM */
public static long updatedMS = 1280389064285L;
/** AD_Table_ID=662 */
public static int Table_ID;
 // =662;

/** TableName=M_RelatedProduct */
public static String Table_Name="M_RelatedProduct";

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
StringBuilder sb = new StringBuilder ("X_M_RelatedProduct[").Append(Get_ID()).Append("]");
return sb.ToString();
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
/** Set Product.
@param M_Product_ID Product, Service, Item */
public void SetM_Product_ID (int M_Product_ID)
{
if (M_Product_ID < 1) throw new ArgumentException ("M_Product_ID is mandatory.");
Set_ValueNoCheck ("M_Product_ID", M_Product_ID);
}
/** Get Product.
@return Product, Service, Item */
public int GetM_Product_ID() 
{
Object ii = Get_Value("M_Product_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetM_Product_ID().ToString());
}
/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name)
{
if (Name == null) throw new ArgumentException ("Name is mandatory.");
if (Name.Length > 60)
{
log.Warning("Length > 60 - truncated");
Name = Name.Substring(0,60);
}
Set_Value ("Name", Name);
}
/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() 
{
return (String)Get_Value("Name");
}

/** RelatedProductType AD_Reference_ID=313 */
public static int RELATEDPRODUCTTYPE_AD_Reference_ID=313;
/** Alternative = A */
public static String RELATEDPRODUCTTYPE_Alternative = "A";
/** Web Promotion = P */
public static String RELATEDPRODUCTTYPE_WebPromotion = "P";
/** Supplemental = S */
public static String RELATEDPRODUCTTYPE_Supplemental = "S";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsRelatedProductTypeValid (String test)
{
return test.Equals("A") || test.Equals("P") || test.Equals("S");
}
/** Set Related Product Type.
@param RelatedProductType Related Product Type */
public void SetRelatedProductType (String RelatedProductType)
{
if (RelatedProductType == null) throw new ArgumentException ("RelatedProductType is mandatory");
if (!IsRelatedProductTypeValid(RelatedProductType))
throw new ArgumentException ("RelatedProductType Invalid value - " + RelatedProductType + " - Reference_ID=313 - A - P - S");
if (RelatedProductType.Length > 1)
{
log.Warning("Length > 1 - truncated");
RelatedProductType = RelatedProductType.Substring(0,1);
}
Set_Value ("RelatedProductType", RelatedProductType);
}
/** Get Related Product Type.
@return Related Product Type */
public String GetRelatedProductType() 
{
return (String)Get_Value("RelatedProductType");
}

/** RelatedProduct_ID AD_Reference_ID=162 */
public static int RELATEDPRODUCT_ID_AD_Reference_ID=162;
/** Set Related Product.
@param RelatedProduct_ID Related Product */
public void SetRelatedProduct_ID (int RelatedProduct_ID)
{
if (RelatedProduct_ID < 1) throw new ArgumentException ("RelatedProduct_ID is mandatory.");
Set_ValueNoCheck ("RelatedProduct_ID", RelatedProduct_ID);
}
/** Get Related Product.
@return Related Product */
public int GetRelatedProduct_ID() 
{
Object ii = Get_Value("RelatedProduct_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
}

}
