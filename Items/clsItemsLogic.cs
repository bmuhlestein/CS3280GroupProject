using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Items
{
    class clsItemsLogic
    {/*
        The last form needed is a form to update the def table which contains all the items for the 
business.  This form can be accessed through the menu and only when an invoice is not being 
edited or a new invoice is being entered.  This form will list all the items in a list (like a 
DataGrid).  The items will consist of a code, cost, and description.  From here the user can add 
new items, edit existing items, or delete existing items.  If the user tries to delete an item that is 
on an invoice, don’t allow the user to do so.  Instead warn them with a message that tells the user 
which invoices that item is used on.  When an item is updated, the code must not be allowed to be 
updated because it is the primary key, only the description and cost may be updated.  When the 
user closes the update def table form, make sure to update the drop-down box as to reflect any 
changes made by the user.  Also update the current invoice because its item name might have 
been updated.*/

        // All Main Methods will handle message box to return thr state of the action. 

        // Call Get Table This will be called when Form loads 

        //method needs to reload grid after button submit has been clicked

        // Method for error handling THis will build and return a string that indicates what happened.

        // Possible methdo to return a data set with new equipment? Or have Brandon Handle this upon close.       

        //Add Redrocd 
            // Needs to accept name, Desc, Cost  and generate the id. 
                // THe id will bet current cout of records + 1 

        //Check if there are any invoice records 
            // Delete Items if not included in an invoice 
            

        //Update Item Records 
            //Needs to accept the ID and all Fields. 
            // Builds a string beginning with Set 

            //Maybe send a Dataset filled with Infomation.

           
    }
}
