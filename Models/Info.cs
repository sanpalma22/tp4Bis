namespace tp4Bis.Models;
public static class Info{
    private static List<Pais>ListaPaises=new List<Pais>();
    private static void inicializarLista(){
        ListaPaises.Add(new Pais("Argentina","imagenes/argentina.jpg",45000000,new DateTime(9,7,1816), "Las montañas de los Andes, lagos glaciales y praderas en las Pampas, la tierra tradicional de pastoreo de su famoso ganado. El país es conocido por el baile y la música del tango. Su gran capital cosmopolita, Buenos Aires, se centra en la Plaza de Mayo, rodeada por imponentes edificios del siglo XIX, como la Casa Rosada, el icónico palacio presidencial."));
        ListaPaises.Add(new Pais("Brasil","imagenes/brasil.jpg",214000000,new DateTime(7,9,1822),"La cuenca del Amazonas en el norte hasta los viñedos y las enormes cataratas del Iguazú en el sur. Río de Janeiro, simbolizado por su estatua de 38 m del Cristo Redentor sobre el cerro del Corcovado, es famoso por sus ajetreadas playas Copacabana e Ipanema, junto con su enorme y estridente festival del Carnaval, que cuenta con carros alegóricos, exuberantes disfraces y danza y música samba.");
        ListaPaises.Add(new Pais("Italia","imagenes/italia.png",59000000,new DateTime(),"Su capital, Roma, es hogar del Vaticano, de ruinas antiguas y de obras de arte emblemáticas. Otras ciudades importantes son Florencia, con obras maestras del renacimiento, como el David de Miguel Ángel y el Domo de Brunelleschi; Venecia, la ciudad de los canales; y Milán, la capital italiana de la moda."));
        ListaPaises.Add(new Pais("España","imagenes/españa",47000000,new DateTime(),"En Madrid, su capital, se encuentra el Palacio Real y el Museo del Prado, que alberga obras de maestros europeos. Segovia tiene un castillo medieval (el Alcázar) y un acueducto romano intacto. La capital de Cataluña, Barcelona, se caracteriza por las obras modernistas extravagantes de Antoni Gaudí, como el templo de la Sagrada Familia."));
        
    }
    public static List<Pais> ListarPaises(){

    }
    public static Pais DetallePais(string nomPais){

    }
}