using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mecanografia
{
    internal class Program
    {
        static void Main(string[] args) {
            int errores = 0;

            string[] frases =
{
    "Pedro", "Joo", "Maria", "Ana", "Lucas", "Fernanda", "Carlos", "Patrícia", "Roberto", "Juliana",
    "casa", "perro", "gato", "árbol", "libro", "agua", "sol", "luna", "cielo", "tierra",
    "mesa", "silla", "ventana", "puerta", "pared", "techo", "piso", "cocina", "baño", "habitación",
    "hombre", "mujer", "niño", "niña", "familia", "amigo", "vecino", "ciudad", "país", "mundo",
    "tiempo", "día", "noche", "mañana", "tarde", "semana", "mes", "año", "hora", "minuto",
    "segundo", "ayer", "hoy", "mañana", "pasado", "futuro", "siempre", "nunca", "ahora", "después",
    "antes", "durante", "mientras", "pronto", "tarde", "temprano", "rápido", "lento", "mucho", "poco",
    "todo", "nada", "algo", "ninguno", "varios", "algunos", "cada", "varios", "demasiado", "suficiente",
    "grande", "pequeño", "alto", "bajo", "largo", "corto", "ancho", "estrecho", "pesado", "ligero",
    "frío", "caliente", "tibio", "fresco", "duro", "blando", "áspero", "suave", "seco", "mojado",
    "limpio", "sucio", "nuevo", "viejo", "bueno", "malo", "bonito", "feo", "caro", "barato",
    "feliz", "triste", "enojado", "contento", "sorprendido", "asustado", "cansado", "aburrido", "emocionado", "nervioso",
    "comer", "beber", "dormir", "despertar", "hablar", "escuchar", "ver", "mirar", "oir", "sentir",
    "tocar", "oler", "saborear", "pensar", "creer", "saber", "entender", "aprender", "enseñar", "estudiar",
    "trabajar", "jugar", "cantar", "bailar", "reir", "llorar", "gritar", "susurrar", "caminar", "correr",
    "saltar", "nadar", "volar", "conducir", "viajar", "llegar", "salir", "entrar", "quedarse", "partir",
    "dar", "recibir", "tomar", "dejar", "encontrar", "perder", "buscar", "guardar", "abrir", "cerrar",
    "empezar", "terminar", "continuar", "parar", "esperar", "intentar", "lograr", "fallar", "ayudar", "molestar",
    "amar", "odiar", "gustar", "disgustar", "preferir", "desear", "necesitar", "querer", "deber", "poder",
    "rojo", "azul", "verde", "amarillo", "blanco", "negro", "gris", "rosado", "morado", "naranja",
    "marron", "beige", "celeste", "turquesa", "violeta", "dorado", "plateado", "bronce", "cobre", "transparente",
    "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez",
    "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve", "veinte",
    "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa", "cien", "mil", "millón",
    "primero", "segundo", "tercero", "cuarto", "quinto", "sexto", "séptimo", "octavo", "noveno", "décimo",
    "final", "inicial", "siguiente", "anterior", "central", "lateral", "superior", "inferior", "exterior", "interior",
    "norte", "sur", "este", "oeste", "oriental", "occidental", "septentrional", "meridional", "derecha", "izquierda",
    "arriba", "abajo", "adelante", "atrás", "cerca", "lejos", "aquí", "allí", "ahí", "donde",
    "quien", "que", "cual", "cuando", "como", "porque", "cuanto", "cuantos", "cuyo", "cuyos",
    "y", "o", "pero", "porque", "aunque", "si", "no", "tal vez", "quizás", "claro",
    "hola", "adiós", "gracias", "por favor", "perdón", "lo siento", "buenos días", "buenas tardes", "buenas noches", "hasta luego",
    "bienvenido", "felicidades", "salud", "amor", "paz", "guerra", "vida", "muerte", "esperanza", "miedo",
    "verdad", "mentira", "realidad", "sueño", "imaginación", "pensamiento", "idea", "opinión", "consejo", "sugerencia",
    "problema", "solución", "pregunta", "respuesta", "duda", "certeza", "razón", "sinrazón", "ventaja", "desventaja",
    "éxito", "fracaso", "ganar", "perder", "intentar", "lograr", "fracasar", "acertar", "errar", "mejorar",
    "empeorar", "cambiar", "permanecer", "avanzar", "retroceder", "progresar", "decadencia", "crecimiento", "desarrollo", "estancamiento",
    "comienzo", "final", "inicio", "terminación", "origen", "destino", "fuente", "resultado", "consecuencia", "causa",
    "efecto", "motivo", "propósito", "objetivo", "meta", "sueño", "deseo", "necesidad", "ambición", "ilusión",
    "recuerdo", "olvido", "memoria", "historia", "pasado", "presente", "futuro", "eternidad", "momento", "instante",
    "siempre", "nunca", "a veces", "frecuentemente", "rara vez", "ocasionalmente", "generalmente", "normalmente", "usualmente", "constantemente",
    "pronto", "tarde", "temprano", "inmediatamente", "después", "antes", "durante", "mientras", "hasta", "desde",
    "hacia", "contra", "a favor", "en contra", "acerca", "sobre", "bajo", "encima", "debajo", "alrededor",
    "dentro", "fuera", "junto", "separado", "unido", "dividido", "completo", "incompleto", "perfecto", "imperfecto",
    "simple", "complejo", "fácil", "difícil", "posible", "imposible", "probable", "improbable", "seguro", "inseguro",
    "cierto", "incierto", "definitivo", "temporal", "permanente", "eterno", "pasajero", "durable", "frágil", "resistente",
    "fuerte", "débil", "sólido", "líquido", "gaseoso", "duro", "blando", "flexible", "rígido", "elástico",
    "transparente", "opaco", "brillante", "opaco", "claro", "oscuro", "colorido", "incoloro", "blanco", "negro",
    "calido", "frío", "templado", "húmedo", "seco", "lluvioso", "soleado", "nublado", "ventoso", "tranquilo",
    "ruidoso", "silencioso", "alegre", "triste", "animado", "aburrido", "interesante", "monótono", "variado", "repetitivo",
    "nuevo", "viejo", "moderno", "antiguo", "actual", "pasado de moda", "tradicional", "innovador", "común", "raro",
    "familiar", "desconocido", "popular", "impopular", "famoso", "anónimo", "importante", "trivial", "significativo", "insignificante",
    "necesario", "innecesario", "útil", "inútil", "práctico", "impráctico", "funcional", "disfuncional", "eficaz", "ineficaz",
    "productivo", "improductivo", "rentable", "no rentable", "económico", "costoso", "barato", "caro", "asequible", "inasequible",
    "accesible", "inaccesible", "disponible", "no disponible", "abundante", "escaso", "suficiente", "insuficiente", "limitado", "ilimitado",
    "libre", "ocupado", "vacío", "lleno", "liviano", "pesado", "grande", "pequeño", "alto", "bajo",
    "largo", "corto", "ancho", "estrecho", "grueso", "delgado", "profundo", "superficial", "plano", "inclinado",
    "recto", "curvo", "redondo", "cuadrado", "triangular", "circular", "ovalado", "rectangular", "hexagonal", "octogonal",
    "simétrico", "asimétrico", "regular", "irregular", "uniforme", "diverso", "homogéneo", "heterogéneo", "similar", "diferente",
    "igual", "desigual", "equivalente", "distinto", "opuesto", "contrario", "complementario", "alternativo", "adicional", "extra",
    "principal", "secundario", "terciario", "primario", "básico", "avanzado", "elemental", "complejo", "sofisticado", "sencillo",
    "complicado", "difícil", "fácil", "sencillo", "intrincado", "directo", "indirecto", "explícito", "implícito", "obvio",
    "evidente", "claro", "confuso", "ambiguo", "vago", "preciso", "exacto", "inexacto", "correcto", "incorrecto",
    "verdadero", "falso", "auténtico", "falso", "original", "copia", "genuino", "falsificado", "legal", "ilegal",
    "legítimo", "ilegítimo", "válido", "inválido", "aceptable", "inaceptable", "apropiado", "inapropiado", "conveniente", "inconveniente",
    "adecuado", "inadecuado", "pertinente", "impertinente", "relevante", "irrelevante", "importante", "trivial", "significativo", "insignificante",
    "necesario", "innecesario", "urgente", "no urgente", "prioritario", "secundario", "fundamental", "superficial", "esencial", "accidental",
    "intrínseco", "extrínseco", "inherente", "adquirido", "natural", "artificial", "orgánico", "inorgánico", "vivo", "muerto",
    "animado", "inanimado", "humano", "animal", "vegetal", "mineral", "terrestre", "acuático", "aéreo", "espacial",
    "universal", "local", "global", "regional", "nacional", "internacional", "mundial", "continental", "oceánico", "atmosférico",
    "geográfico", "histórico", "cultural", "social", "político", "económico", "tecnológico", "científico", "artístico", "deportivo",
    "religioso", "espiritual", "filosófico", "psicológico", "físico", "mental", "emocional", "intelectual", "racional", "irracional",
    "lógico", "ilógico", "coherente", "incoherente", "consistente", "inconsistente", "válido", "inválido", "solido", "débil",
    "fuerte", "frágil", "resistente", "vulnerable", "estable", "inestable", "seguro", "inseguro", "confiable", "poco fiable",
    "preciso", "impreciso", "exacto", "inexacto", "correcto", "incorrecto", "acertado", "equivocado", "verdadero", "falso",
    "real", "irreal", "auténtico", "falso", "sincero", "falso", "honesto", "deshonesto", "ético", "no ético",
    "moral", "inmoral", "justo", "injusto", "bueno", "malo", "positivo", "negativo", "favorable", "desfavorable",
    "optimista", "pesimista", "realista", "idealista", "práctico", "teórico", "concreto", "abstracto", "específico", "general",
    "particular", "universal", "único", "común", "raro", "frecuente", "infrecuente", "habitual", "inusual", "normal",
    "anormal", "típico", "atípico", "convencional", "innovador", "tradicional", "moderno", "antiguo", "actual", "obsoleto",
    "pasado", "presente", "futuro", "eterno", "temporal", "permanente", "durable", "efímero", "momentáneo", "prolongado",
    "breve", "largo", "corto", "inmediato", "posterior", "anterior", "simultáneo", "consecutivo", "alterno", "continuo",
    "intermitente", "constante", "variable", "fijo", "móvil", "estático", "dinámico", "activo", "pasivo", "neutral",
    "positivo", "negativo", "beneficioso", "perjudicial", "favorable", "desfavorable", "ventajoso", "desventajoso", "provechoso", "inútil",
    "valioso", "insignificante", "importante", "trivial", "relevante", "irrelevante", "significativo", "insignificante", "notable", "imperceptible",
    "evidente", "oculto", "visible", "invisible", "claro", "oscuro", "brillante", "opaco", "transparente", "translúcido",
    "opaco", "reflectante", "mate", "brillante", "luminoso", "oscuro", "iluminado", "sombreado", "radiante", "apagado",
    "colorido", "incoloro", "multicolor", "monocromático", "vibrante", "pálido", "saturado", "desaturado", "pastel", "fluorescente",
    "cálido", "frío", "templado", "neutral", "contrastante", "armonioso", "discordante", "combinado", "separado", "mezclado",
    "puro", "impuro", "natural", "artificial", "genuino", "falso", "auténtico", "falsificado", "original", "copia",
    "tradicional", "innovador", "conservador", "progresista", "liberal", "conservador", "radical", "moderado", "extremista", "neutral",
    "objetivo", "subjetivo", "imparcial", "parcial", "justo", "injusto", "equitativo", "inequitativo", "balanceado", "desequilibrado",
    "democrático", "autoritario", "dictatorial", "participativo", "inclusivo", "exclusivo", "abierto", "cerrado", "flexible", "rígido",
    "tolerante", "intolerante", "respetuoso", "irrespetuoso", "amable", "grosero", "cortés", "descortés", "educado", "maleducado",
    "refinado", "tosco", "elegante", "ordinario", "sofisticado", "simple", "complejo", "complicado", "sencillo", "intrincado",
    "organizado", "desorganizado", "ordenado", "desordenado", "limpio", "sucio", "pulcro", "descuidado", "aseado", "desaliñado",
    "cuidadoso", "descuidado", "detallista", "superficial", "meticuloso", "negligente", "responsable", "irresponsable", "confiable", "poco fiable",
    "eficiente", "ineficiente", "productivo", "improductivo", "activo", "pasivo", "dinámico", "estático", "ágil", "lento",
    "rápido", "pausado", "veloz", "tranquilo", "apresurado", "calmado", "nervioso", "relajado", "tenso", "suelto",
    "firme", "flojo", "apretado", "holgado", "ajustado", "amplio", "estrecho", "ancho", "delgado", "grueso",
    "pesado", "ligero", "compacto", "esponjoso", "duro", "blando", "resistente", "frágil", "flexible", "rígido",
    "elástico", "plástico", "maleable", "quebradizo", "poroso", "impermeable", "transparente", "opaco", "brillante", "mate",
    "liso", "rugoso", "suave", "áspero", "sedoso", "lanoso", "escalofriante", "pegajoso", "resbaladizo", "adherente",
    "seco", "húmedo", "mojado", "empapado", "encharcado", "acuoso", "oleoso", "grasoso", "ceroso", "polvoriento",
    "arenoso", "fangoso", "barroso", "cristalino", "turbio", "claro", "oscuro", "brillante", "opaco", "radiante",
    "luminoso", "sombrío", "resplandeciente", "apagado", "llameante", "humo", "neblina", "niebla", "rocío", "escarcha",
    "hielo", "nieve", "lluvia", "granizo", "tormenta", "trueno", "relámpago", "viento", "brisa", "huracán",
    "tornado", "terremoto", "erupción", "inundación", "sequía", "ola", "marea", "corriente", "remolino", "cascada",
    "río", "lago", "mar", "océano", "bahía", "golfo", "estrecho", "canal", "península", "isla",
    "archipiélago", "continente", "montaña", "colina", "valle", "llanura", "meseta", "acantilado", "cañón", "cueva",
    "volcán", "desierto", "jungla", "bosque", "selva", "pradera", "sabana", "tundra", "pantano", "delta",
    "oasis", "glaciar", "fiordo", "arrecife", "atolón", "duna", "caverna", "gruta", "abismo", "precipicio",
    "cima", "cumbre", "base", "fondo", "orilla", "costa", "playa", "arena", "roca", "piedra",
    "grava", "arcilla", "limo", "turba", "marga", "granito", "mármol", "pizarra", "cuarcita", "basalto",
    "obsidiana", "piedra pómez", "yeso", "caliza", "arenisca", "carbón", "petróleo", "gas", "mineral", "metal",
    "oro", "plata", "cobre", "hierro", "plomo", "zinc", "estaño", "níquel", "aluminio", "mercurio",
    "uranio", "platino", "bronce", "acero", "latón", "aleación", "cristal", "vidrio", "cerámica", "porcelana",
    "loza", "barro", "greda", "arcilla", "cemento", "concreto", "hormigón", "asfalto", "alquitrán", "brea",
    "resina", "látex", "caucho", "plástico", "poliéster", "nailon", "rayón", "seda", "lana", "algodón",
    "lino", "cáñamo", "yute", "esparto", "paja", "cuero", "piel", "pelaje", "pluma", "escama",
    "corcho", "madera", "tabla", "listón", "vigas", "poste", "tronco", "rama", "hoja", "flor",
    "fruto", "semilla", "raíz", "tallo", "bulbo", "tubérculo", "rizoma", "brotes", "yema", "corteza",
    "savia", "resina", "néctar", "polen", "espora", "musgo", "helecho", "hongo", "seta", "levadura",
    "bacteria", "virus", "protozoo", "alga", "liquen", "parásito", "planta", "animal", "insecto", "arácnido",
    "crustáceo", "molusco", "peces", "anfibio", "reptil", "ave", "mamífero", "mono", "simio", "primate",
    "roedor", "carnívoro", "herbívoro", "omnivoro", "marsupial", "murciélago", "cetáceo", "ungulado", "felino", "canino",
    "équido", "bovino", "porcino", "ovino", "caprino", "cérvido", "súido", "proboscídeo", "pinnípedo", "mustélido",
    "foca", "león", "tigre", "leopardo", "guepardo", "jaguar", "pantera", "lince", "puma", "gato",
    "perro", "lobo", "zorro", "hiena", "oso", "panda", "koala", "canguro", "wallaby", "wombat",
    "demonio", "ornitorrinco", "equidna", "erizo", "topo", "musaraña", "ardilla", "marmota", "castor", "ratón",
    "rata", "hámster", "jerbo", "chinchilla", "conejo", "liebre", "pika", "cobaya", "capibara", "nutria",
    "comadreja", "hurón", "tejón", "mofeta", "mapache", "oso hormiguero", "armadillo", "perezoso", "pangolín", "elefante",
    "rinoceronte", "hipopótamo", "tapir", "jirafa", "okapi", "cebra", "caballo", "asno", "mula", "cebroide",
    "cerdo", "jabalí", "hipopótamo", "camello", "dromedario", "llama", "alpaca", "vicuña", "guanaco", "ciervo",
    "alce", "reno", "caribú", "antílope", "gacela", "impala", "ñu", "búfalo", "bisonte", "yak",
    "buey", "vaca", "toro", "ternero", "novillo", "vaquilla", "buey almizclero", "cabra", "oveja", "cordero",
    "carnero", "borrego", "cabra montés", "íbice", "muflón", "chamois", "serow", "goral", "takín", "jabalí",
    "faisán", "pavo", "gallina", "gallo", "pollo", "codorniz", "perdiz", "urogallo", "avestruz", "emu",
    "ñandú", "casuario", "kiwi", "pinguino", "albatros", "petrel", "cormorán", "pelícano", "garza", "cigüeña",
    "ibis", "espátula", "flamenco", "ánade", "pato", "ganso", "cisne", "grulla", "focha", "gallineta",
    "somormujo", "colimbo", "zampullín", "charran", "gaviota", "pagaza", "fumarel", "rayador", "alcida", "arao",
    "frailecillo", "mérgulo", "paloma", "tórtola", "tórtola turca", "cuco", "lechuza", "búho", "mochuelo", "autillo",
    "chotacabras", "vencejo", "colibrí", "martín pescador", "abejaruco", "carraca", "abubilla", "cálao", "tucán", "barbudo",
    "pájaro carpintero", "trepador", "agateador", "pito", "torcecuello", "alondra", "cogujada", "totovía", "calandria", "terrera",
    "bisbita", "lavandera", "accentor", "petirrojo", "ruiseñor", "colirrojo", "tarabilla", "collalba", "roquero", "zorzal",
    "mirlo", "estornino", "arrendajo", "urraca", "corneja", "cuervo", "grajilla", "chova", "picogordo", "camachuelo",
    "verderón", "jilguero", "pardillo", "piquituerto", "pinzón", "escribano", "gorrión", "pardal", "tejedor", "viuda",
    "amadina", "diamante", "canario", "periquito", "cacatúa", "lorito", "guacamayo", "ara", "cotorra", "agapornis",
    "paloma", "tórtola", "columbina", "tórtola diamante", "codorniz", "faisán", "perdiz", "urogallo", "avestruz", "emu",
    "ñandú", "casuario", "kiwi", "pinguino", "albatros", "petrel", "cormorán", "pelícano", "garza", "cigüeña",
    "ibis", "espátula", "flamenco", "ánade", "pato", "ganso", "cisne", "grulla", "focha", "gallineta",
    "somormujo", "colimbo", "zampullín", "charran", "gaviota", "pagaza", "fumarel", "rayador", "alcida", "arao",
    "frailecillo", "mérgulo", "paloma", "tórtola", "tórtola turca", "cuco", "lechuza", "búho", "mochuelo", "autillo",
    "chotacabras", "vencejo", "colibrí", "martín pescador", "abejaruco", "carraca", "abubilla", "cálao", "tucán", "barbudo",
    "pájaro carpintero", "trepador", "agateador", "pito", "torcecuello", "alondra", "cogujada", "totovía", "calandria", "terrera",
    "bisbita", "lavandera", "accentor", "petirrojo", "ruiseñor", "colirrojo", "tarabilla", "collalba", "roquero", "zorzal",
    "mirlo", "estornino", "arrendajo", "urraca", "corneja", "cuervo", "grajilla", "chova", "picogordo", "camachuelo",
    "verderón", "jilguero", "pardillo", "piquituerto", "pinzón", "escribano", "gorrión", "pardal", "tejedor", "viuda",
    "amadina", "diamante", "canario", "periquito", "cacatúa", "lorito", "guacamayo", "ara", "cotorra", "agapornis",
    "rana", "sapo", "salamandra", "tritón", "axolote", "cecilia", "iguana", "camaleón", "gecko", "lagarto",
    "lagartija", "eslizón", "varano", "monitor", "dragón", "serpiente", "culebra", "víbora", "cobra", "pitón",
    "boa", "anaconda", "tortuga", "galápago", "caimán", "cocodrilo", "gavial", "tiburón", "raya", "quimera",
    "lamprea", "mixino", "esturión", "salmón", "trucha", "lucio", "carpa", "barbo", "tenca", "anguila",
    "morena", "pez gato", "bagre", "siluro", "pez dorado", "carpín", "guppy", "molly", "platys", "espada",
    "pez ángel", "disco", "óscar", "cíclido", "betta", "gourami", "pez globo", "pez erizo", "pez piedra", "pez león",
    "pez payaso", "pez cirujano", "pez mariposa", "pez ballesta", "pez loro", "pez murciélago", "pez luna", "pez vela", "pez espada", "atún",
    "bonito", "caballa", "jurel", "pez limón", "dorado", "pez volador", "pez pipa", "caballito de mar", "pez pipa fantasma", "pez pipa de fuego",
    "pez pipa dragón", "pez pipa bandera", "pez pipa alga", "pez pipa hoja", "pez pipa fantasma", "pez pipa de fuego", "pez pipa dragón", "pez pipa bandera", "pez pipa alga", "pez pipa hoja",
    "medusa", "anémona", "coral", "hidra", "esponja", "estrella de mar", "erizo de mar", "ofiura", "lirio de mar", "holoturia",
    "caracol", "babosa", "almeja", "mejillón", "ostra", "vieira", "berberecho", "navaja", "bígaro", "lapas",
    "quitón", "calamar", "pulpo", "sepia", "nautilo", "araña", "escorpión", "ácaro", "garrapata", "opilión",
    "pseudoescorpión", "solífugo", "escolopendra", "milpiés", "cochinilla", "isópodo", "anfípodo", "krill", "langosta", "bogavante",
    "cangrejo", "centolla", "nécoras", "buey de mar", "ermitaño", "camarón", "gamba", "quisquilla", "langostino", "cigala",
    "percebe", "mosquito", "mosca", "tábano", "jején", "chinche", "pulgón", "cigarra", "saltamontes", "grillo",
    "langosta", "mantis", "cucaracha", "termita", "libélula", "caballito del diablo", "efímera", "plecóptero", "tisanuro", "lepisma",
    "mariposa", "polilla", "esfinge", "gusano", "oruga", "larva", "ninfa", "crisálida", "pupa", "mosca",
    "abeja", "avispa", "avispón"
            };

            Random random = new Random();
            Console.CursorVisible = false;

            while (true)
            {
                //Limpiar la pantalla
                Console.Clear();

                //Tener frase seleccionada de manera aleatoria
                string fraseRand = frases[random.Next(frases.Length)];

                //Escribir la frase en la consola
                TituloErroresEtc();
                Console.SetCursorPosition(0, 7);
                Console.WriteLine($"Errores: [   ]");
                Console.SetCursorPosition(10, 7);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errores);
                Console.SetCursorPosition(15, 7);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" Frase: {fraseRand}");
                string linea = new string('_', fraseRand.Length);
                Console.SetCursorPosition(15, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"        {linea}");

                //Verificar si lo esta escribiendo correctamente
                for (int i = 0; i < fraseRand.Length; i++)
                {
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Black;
                    var key = Console.ReadKey();

                    if (key.KeyChar == fraseRand[i])
                    {
                        Console.SetCursorPosition(i + 23, 7);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(key.KeyChar);
                    }
                    else
                    {
                        i--;
                        errores++;
                        Console.SetCursorPosition(10, 7);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errores);
                    }

                }
            }
        }
        static void TituloErroresEtc() {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(@" __  __ _____ ____    _    _   _  ___   ____ ____      _    _____ ___    _    ");
            Console.WriteLine(@"|  \/  | ____/ ___|  / \  | \ | |/ _ \ / ___|  _ \    / \  |  ___|_ _|  / \  ");
            Console.WriteLine(@"| |\/| |  _|| |     / _ \ |  \| | | | | |  _| |_) |  / _ \ | |_   | |  / _ \  ");
            Console.WriteLine(@"| |  | | |__| |___ / ___ \| |\  | |_| | |_| |  _ <  / ___ \|  _|  | | / ___ \ ");
            Console.WriteLine(@"|_|  |_|_____\____/_/   \_\_| \_|\___/ \____|_| \_\/_/   \_\_|   |___/_/   \_\");
            Console.WriteLine(@"By Froy.");
        }
    }
}
