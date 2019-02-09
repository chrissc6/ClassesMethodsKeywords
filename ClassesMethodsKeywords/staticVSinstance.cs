using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsKeywords
{
    class staticVSinstance
    {
    }
}
//The absence of the keyword "static" means that whatever is defined belongs to an instance (created with the "new" keyword)

//Static- means whatever is marked as static does not belong to any object instance created,
//it belongs to the class itself 
//(Console.WriteLine = console is static, you never have to create a new console lol, we can just use the writeline method)
//Static members can not use instance members
//If a class is static, all members must also be static
//You cannot instantiate a static class (cant be used with the "new" keyword) 
//You cannot inherit a static class (not good for extension)
//There is only ever one copy of a static
//Making something static ask "Is this operating on an instance of a type, or is it just related to the type?"
//Like the math value pi- it isnt related to a particular circle, it is related to all circles

//What to make static?
//Application settings (paths to directories, files | database information | server information | log settings)
//General calculations (like the math class)
//General purpose data (any object there should only ever be one of "The Singleton")
//Methods that do general tasks

//Static is slightly more efficient
//Less code to write than instantiating objects
//Moving general purpose methods to their own classes can keep code cleaner (calculations class or whatever)

//If a static reaches into instances of object, it probably shouldnt be static (perhaps it belongs in the instance)