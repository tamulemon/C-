using System;

namespace @interface
{
	interface Ilogger
	{
		// all interface does is to specify a 'contract'. what are the methods included. no code is in interface
		// only one method in this case, it's void and it takes a string parameter
		// it does't specify how this method will be implemented. This is upto classes that implement the interface
		// which class to use(logic),  is determined by the factory

		//  Interface members are automatically public. Can not use the public key word here. will error
		// all implementation need ot have the same methods as specified in the interface
		void writeLog (string input);
	}
}

