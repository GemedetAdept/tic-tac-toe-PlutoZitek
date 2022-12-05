public class GraphicsDriver {

	public static Dictionary<string, string> boardSegments = new Dictionary<string, string> {

		{"boardTop", 
		@" ▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁   
		/                                                   /║  
		╔════════════════╦════════════════╦════════════════╗ ║  "},

		{"boardMidDiv", 
		@"╠════════════════╬════════════════╬════════════════╣ ║  "},

		{"boardBottom", 
		@"╚════════════════╩════════════════╩════════════════╝    "},

		{"columnSingle", 
		@"║
		║
		║
		║
		║
		║
		║"},

		{"columnDouble", 
		@"║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  "},

		{"columnEnd", 
		@"║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║/   "},

		{"squareBlank", 
		@"                
		                
		                
		                
		                
		                
		                "},

		{"squareCross", 
		@"                
		   ██▖    ▗██   
		    ▝██▖▗██▘    
		      ▐██▌      
		    ▗██▘▝██▖    
		   ██▘    ▝██   
		                "},

		{"squareCircle", 
		@"                
		    ▗██████▖    
		    █▘    ▝█    
		    █      █    
		    █▖    ▗█    
		    ▝██████▘    
		                "},

		};

	public static string StripTabs(string inputString) {

		string outputString = inputString.Replace("\t", "");
		return outputString;
	}

	public static void PrintGameBoard(GameBoard currentBoard) {


	}
}