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
        await DisplayAlert("O Duque e Eu", "Focada na hist�ria de amor entre Daphne, a mais velhas das irm�s Bridgerton, e Simon Basset, o charmoso duque de Hastings, a obra mostra como o plano de atrair novos pretendentes para a jovem e manter o duque longe de um casamento sai do controle de ambos, criando uma rela��o inesperada entre as personagens.", "OK");
    }

    private async void livro2_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("O Visconde Que Me Amava", "Em 304 p�ginas, Julia Quinn traz ao mundo a hist�ria de quando Anthony Bridgerton decide abandonar a vida de rapaz libertino e come�ar um noivado, escolhendo a suposta candidata ideal, mas acaba se apaixonando pela irm� da jovem no caminho.", "OK");
    }

    private async void livro3_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Um Perfeito Cavalheiro", "Julia Quinn traz uma releitura da cl�ssica hist�ria de Cinderela, adaptada ao contexto dos irm�os Bridgerton. A obra narra a hist�ria da paix�o entre Sophie e Benedict, que, para viverem o amor de conto de fadas, precisar�o reconsiderar suas cren�as ou ent�o lutar contra este sentimento.", "OK");
    }

    private async void livro4_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Os Segredos de Colin Bridgerton", "Penelope � secretamente apaixonada por Colin desde a inf�ncia, mas s� aos poucos o terceiro filho da fam�lia Bridgerton come�a a ter uma outra vis�o da amiga de inf�ncia. Ela deixa de ser uma jovem ignorada pela sociedade para se tornar uma mulher bem humorada e que carrega uma beleza �nica. Por�m, o que parecia se encaminhar para uma hist�ria de amor, encontra empecilhos quando os jovens entram em um conflito ap�s descobrirem grandes segredos um do outro, e precisam decidir se essas revela��es impedem ou n�o a evolu��o do romance.", "OK");
    }

    private async void livro5_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Para Sir Phillip, Com Amor", "Em Para Sir Phillip, com Amor � explorada a hist�ria de Eloise Bridgerton, a segunda mulher e quinta filha da fam�lia Bridgerton. O livro explica como ela se apaixona por Sir Phillip, vi�vo de sua prima. Adoradora das cartas, Eloise decide escrever para Sir Phillip, oferecendo suas condol�ncias ap�s a morte de sua esposa. Por�m, o gesto encanta o rapaz, e ambos entram em uma troca de correspond�ncias que, mais tarde, se transforma em um convite para que Eloise passe uma temporada com Sir Phillip para que eles possam se conhecer melhor.", "OK");
    }

    private async void livro6_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("O Conde Enfeiti�ado", "Quatro anos ap�s se tornar vi�va de John, Francesca descobre, em um encontro inesperado, uma nova paix�o em Michael, primo de seu marido que, secretamente, � apaixonado por ela desde o momento em que se conheceram, 36 horas antes de seu casamento. Entre a culpa e o desejo, Julia Quinn mostra em uma narrativa delicada que haver� sempre um final feliz reservado para todos, mas � preciso estar atento para encontr�-lo.", "OK");
    }

    private async void livro7_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Um Beijo Inesquec�vel", "Com sua narrativa distribu�da ao longo de 272 p�ginas, o livro conta como a jovem Bridgerton conhece Gareth St. Clair, neto da conhecida Lady Danbury, e embora tente resistir, acaba descobrindo seu interesse pelo rapaz ap�s tentarem, juntos, traduzir antigos di�rios. Os dois acabam compartilhando confid�ncias e, por fim, trocam um beijo que coloca seus caminhos de vez em uma s� linha.", "OK");
    }

    private async void livro8_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("A Caminho do Altar", "Na hist�ria do �ltimo dos irm�os Bridgerton, A Caminho do Altar traz uma narrativa sobre Gregory Bridgerton, um rom�ntico incur�vel, que quando encontra a �pretendente perfeita�, Hermione Watson, a jovem j� est� encantada por outro rapaz e ignora completamente as investidas do jovem. Por�m, a hist�ria come�a a mudar quando Lucinda Albernathy, melhor amiga de Hermione, decide ajudar Gregory a conquistar a donzela. Os jovens s� n�o contavam com um imprevisto: Lucy, que j� foi prometida a um homem que mal conhece, se apaixona por Gregory.", "OK");
    }

    private async void livro9_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("E Viveram Felizes para Sempre", "No �ltimo livro da s�rie Os Bridgertons, a autora Julia Quinnn presenteia os leitores e apaixonados pela colet�nea com oito ep�logos extras, um para a hist�ria de cada um dos irm�os da famosa fam�lia da elite londrina do s�culo XVII. Com novas narrativas, os f�s t�m uma nova chance de se reconectar com as adoradas personagens.", "OK");
    }
}