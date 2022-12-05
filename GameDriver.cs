public class GameDriver {

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
}