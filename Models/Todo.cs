	using System.ComponentModel;
	
	using System.ComponentModel.DataAnnotations;
	
	
	public class Todo
		{
		
			public int Id {get; set;}
			
			[DisplayName("Titulo")]
			
			[Required(ErrorMessage = "Campo orbrigatório")]
			
            public string Title {get; set;} = "";
			
			[DisplayName("Concluido")]
			
			public bool Done {get; set;}
			
			
			[DisplayName("Criado em")]
			
			
			public DateTime CreateAt {get; set;} = DateTime.Now;
			
			
			[DisplayName("Última atualização")]
			
			
			public DateTime LastUpdate {get; set;} = DateTime.Now;
			
			public string User {get; set;} = "";
			
		}
