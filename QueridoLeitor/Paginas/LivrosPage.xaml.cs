namespace QueridoLeitor.Paginas;

public partial class LivrosPage : ContentPage
{
	public LivrosPage()
	{
		InitializeComponent();
	}

    private async void citar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CitacoesPage());
    }

    private async void livro1_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("O Duque e Eu", "Focada na história de amor entre Daphne, a mais velhas das irmãs Bridgerton, e Simon Basset, o charmoso duque de Hastings, a obra mostra como o plano de atrair novos pretendentes para a jovem e manter o duque longe de um casamento sai do controle de ambos, criando uma relação inesperada entre as personagens.", "OK");
    }

    private async void livro2_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("O Visconde Que Me Amava", "Em 304 páginas, Julia Quinn traz ao mundo a história de quando Anthony Bridgerton decide abandonar a vida de rapaz libertino e começar um noivado, escolhendo a suposta candidata ideal, mas acaba se apaixonando pela irmã da jovem no caminho.", "OK");
    }

    private async void livro3_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Um Perfeito Cavalheiro", "Julia Quinn traz uma releitura da clássica história de Cinderela, adaptada ao contexto dos irmãos Bridgerton. A obra narra a história da paixão entre Sophie e Benedict, que, para viverem o amor de conto de fadas, precisarão reconsiderar suas crenças ou então lutar contra este sentimento.", "OK");
    }

    private async void livro4_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Os Segredos de Colin Bridgerton", "Penelope é secretamente apaixonada por Colin desde a infância, mas só aos poucos o terceiro filho da família Bridgerton começa a ter uma outra visão da amiga de infância. Ela deixa de ser uma jovem ignorada pela sociedade para se tornar uma mulher bem humorada e que carrega uma beleza única. Porém, o que parecia se encaminhar para uma história de amor, encontra empecilhos quando os jovens entram em um conflito após descobrirem grandes segredos um do outro, e precisam decidir se essas revelações impedem ou não a evolução do romance.", "OK");
    }

    private async void livro5_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Para Sir Phillip, Com Amor", "Em Para Sir Phillip, com Amor é explorada a história de Eloise Bridgerton, a segunda mulher e quinta filha da família Bridgerton. O livro explica como ela se apaixona por Sir Phillip, viúvo de sua prima. Adoradora das cartas, Eloise decide escrever para Sir Phillip, oferecendo suas condolências após a morte de sua esposa. Porém, o gesto encanta o rapaz, e ambos entram em uma troca de correspondências que, mais tarde, se transforma em um convite para que Eloise passe uma temporada com Sir Phillip para que eles possam se conhecer melhor.", "OK");
    }

    private async void livro6_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("O Conde Enfeitiçado", "Quatro anos após se tornar viúva de John, Francesca descobre, em um encontro inesperado, uma nova paixão em Michael, primo de seu marido que, secretamente, é apaixonado por ela desde o momento em que se conheceram, 36 horas antes de seu casamento. Entre a culpa e o desejo, Julia Quinn mostra em uma narrativa delicada que haverá sempre um final feliz reservado para todos, mas é preciso estar atento para encontrá-lo.", "OK");
    }

    private async void livro7_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Um Beijo Inesquecível", "Com sua narrativa distribuída ao longo de 272 páginas, o livro conta como a jovem Bridgerton conhece Gareth St. Clair, neto da conhecida Lady Danbury, e embora tente resistir, acaba descobrindo seu interesse pelo rapaz após tentarem, juntos, traduzir antigos diários. Os dois acabam compartilhando confidências e, por fim, trocam um beijo que coloca seus caminhos de vez em uma só linha.", "OK");
    }

    private async void livro8_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("A Caminho do Altar", "Na história do último dos irmãos Bridgerton, A Caminho do Altar traz uma narrativa sobre Gregory Bridgerton, um romântico incurável, que quando encontra a “pretendente perfeita”, Hermione Watson, a jovem já está encantada por outro rapaz e ignora completamente as investidas do jovem. Porém, a história começa a mudar quando Lucinda Albernathy, melhor amiga de Hermione, decide ajudar Gregory a conquistar a donzela. Os jovens só não contavam com um imprevisto: Lucy, que já foi prometida a um homem que mal conhece, se apaixona por Gregory.", "OK");
    }

    private async void livro9_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("E Viveram Felizes para Sempre", "No último livro da série Os Bridgertons, a autora Julia Quinnn presenteia os leitores e apaixonados pela coletânea com oito epílogos extras, um para a história de cada um dos irmãos da famosa família da elite londrina do século XVII. Com novas narrativas, os fãs têm uma nova chance de se reconectar com as adoradas personagens.", "OK");
    }
}