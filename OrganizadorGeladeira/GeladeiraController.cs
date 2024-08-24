using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrganizadorGeladeiraAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeladeiraController : ControllerBase
    {
        private static List<Andar<Produto<string>>> Produtos = new List<Andar<Produto<string>>> {
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(4){ Itens = new List<Produto<string>>
                {
                    new Produto<string>("Manga" , 1),
                    new Produto<string>("Goiaba" ,2),
                    new Produto<string>("Laranja", 3),
                    new Produto<string>("Pera", 4)
                }},
                new Container<Produto<string>>(4) { Itens = new List<Produto<string>>
                {
                    new Produto<string>("Beterraba",5),
                    new Produto<string>("Pepino",6),
                    new Produto<string>("Rabanete",7),
                    new Produto<string>("Alface",8)
                } }
            }),
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(4) { Itens = new List<Produto<string>>
                {
                    new Produto<string>("Leite",9),
                    new Produto<string>("Iogurte",10),
                    new Produto<string>("Queijo",11),
                    new Produto<string>("Requeijão",12)
                } },
                new Container<Produto<string>>(4) { Itens = new List<Produto<string>>
                {
                    new Produto<string>("Manteiga",13),
                    new Produto<string>("Creme de Leite",14),
                    new Produto<string>("Iogurte Natural",15),
                    new Produto<string>("Queijo Minas",16)
                } }
            }),
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(4) { Itens = new List<Produto<string>>
                {
                    new Produto<string>("Presunto Seara",17),
                    new Produto<string>("Frango Caipira",18),
                    new Produto<string>("Costela Suína",19),
                    new Produto<string>("Costela Bovina",20)
                } },
                new Container<Produto<string>>(4) { Itens = new List<Produto<string>>
                {
                    new Produto<string>("Frango",21),
                    new Produto<string>("Carne Bovina",22),
                    new Produto<string>("Ovo",23),
                    new Produto<string>("Bacon",24)
                } }
            })
        };

        public GeladeiraController() 
        {
        }

        // GET: api/<GeladeiraController>
        [HttpGet]
        public IEnumerable<Andar<Produto<string>>> Get()
        {
            return Produtos;
        }

        // GET api/<GeladeiraController>/5
        [HttpGet("{id}")]
        public Produto<string>? Get(int id)
        {
            foreach (var andar in Produtos)
            {
                foreach (var container in andar.Containers)
                {
                    foreach (var produto in container.Itens)
                    {
                        if (produto.Id == id)
                        {
                            return produto;
                        }
                    }
                }
            }

            return null;
        }

        // POST api/<GeladeiraController>
        [HttpPost("{andar}/{container}")]
        public void Post(Produto<string> produto, int andar, int container)
        {
            Produtos[andar].Containers[container].Itens.Add(produto);
        }

        // PUT api/<GeladeiraController>/5
        [HttpPut("{id}")]
        public Produto<string>? Put(int id, Produto<string> update)
        {
            foreach (var andar in Produtos)
            {
                foreach (var container in andar.Containers)
                {
                    foreach (var produto in container.Itens)
                    {
                        if (produto.Id == id)
                        {
                            produto.Nome = update.Nome;
                            return produto;
                        }
                    }
                }
            }

            return null;
        }

        // DELETE api/<GeladeiraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                foreach (var andar in Produtos)
                {
                    foreach (var container in andar.Containers)
                    {
                        foreach (var produto in container.Itens)
                        {
                            if (produto.Id == id)
                            {
                                var posicao = container.Itens.IndexOf(produto);
                                container.RemoverItem(posicao);
                            }
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
