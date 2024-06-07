namespace QueridoLeitor.Paginas;

public partial class PersonagemPage : ContentPage
{
	public PersonagemPage()
	{
        InitializeComponent();
    }

    private async void dap_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Daphne Bridgerton", "A quarta filha e a personagem principal da primeira temporada da s�rie, Daphne � inteligente, gentil e determinada a encontrar o amor verdadeiro na sociedade de Londres.", "OK");
    }

    private async void simon_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Simon Basset", "Tamb�m conhecido como o Duque de Hastings, Simon � o interesse amoroso de Daphne na primeira temporada. Ele � retratado como um homem aristocr�tico, charmoso e com um passado complicado que o torna relutante em se casar e ter filhos.", "OK");
    }

    private async void kate_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Kate Sharma", "Kate � a meia-irm� mais velha de Edwina e se torna a protagonista da segunda temporada de \"Bridgerton\". Ela � retratada como uma mulher inteligente, corajosa e pr�tica, que tem um forte senso de dever para com sua fam�lia.", "OK");
    }

    private async void antho_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Anthony Bridgerton", "O filho mais velho e o Visconde Bridgerton, Anthony � respons�vel por proteger e guiar sua fam�lia ap�s a morte do pai. Ele � retratado como um homem s�rio e respons�vel, embora tamb�m lute com suas pr�prias quest�es emocionais e desejos.", "OK");
    }

    private async void pen_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Penelope Featherington", "A melhor amiga de Eloise e membro da fam�lia Featherington. Penelope � retratada como uma jovem inteligente, mas muitas vezes � subestimada por sua fam�lia e pela sociedade devido � sua timidez e apar�ncia modesta.", "OK");
    }

    private async void colin_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Colin Bridgerton", "O terceiro filho, Colin � retratado como um jovem charmoso e aventureiro que busca encontrar seu lugar na sociedade e descobrir o verdadeiro amor.", "OK");
    }

    private async void eloise_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Eloise Bridgerton", "A quinta filha, Eloise � retratada como uma jovem rebelde e determinada a desafiar as expectativas de g�nero da sociedade. Ela � inteligente, perspicaz e tem uma mente afiada.", "OK");
    }

    private async void violet_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Violet Bridgerton", "A matriarca da fam�lia Bridgerton, Lady Violet � retratada como uma m�e amorosa e protetora que deseja o melhor para seus filhos. Ela � uma figura influente na alta sociedade de Londres e est� sempre atenta �s intrigas e alian�as pol�ticas.", "OK");
    }

    private async void bene_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Benedict Bridgerton", "O segundo filho da fam�lia Bridgerton, Benedict � um artista talentoso que muitas vezes se sente deslocado em rela��o �s expectativas de sua fam�lia. Ele busca explorar sua pr�pria identidade e paix�es fora das conven��es sociais.", "OK");
    }

    private async void greg_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Gregory Bridgerton", "O ca�ula da fam�lia, Gregory � retratado como um jovem idealista que ainda est� descobrindo seu lugar no mundo. Sua inoc�ncia e otimismo s�o caracter�sticas marcantes de sua personalidade.", "OK");
    }

    private async void hya_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Hyacinth Bridgerton", "A filha mais nova e a personagem mais jovem da s�rie, Hyacinth � uma personagem v�vida e espirituosa, muitas vezes proporcionando momentos de humor e franqueza na s�rie.", "OK");
    }

    private async void fran_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Francesca Bridgerton", "A sexta filha, Francesca � uma presen�a mais discreta na s�rie, mas ainda assim tem sua pr�pria hist�ria e desenvolvimento ao longo da trama.", "OK");
    }

    private async void danb_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Danbury", "Uma figura influente na alta sociedade de Londres e uma mentora para Simon. Ela � retratada como uma mulher forte e perspicaz que valoriza a independ�ncia e a determina��o.", "OK");
    }

    private async void rainh_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Rainha Charlotte", "A esposa do Rei George III, a Rainha Charlotte � uma figura importante na alta sociedade de Londres. Ela � retratada como uma mulher perspicaz e influente, cujas opini�es e decis�es afetam o curso dos eventos na s�rie.", "OK");
    }

    private async void edw_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Edwina Sharma", "Edwina � a irm� mais nova da fam�lia Sharma e � apresentada como uma das debutantes mais cobi�adas da temporada em que � apresentada. Ela � retratada como gentil, graciosa e desejada por muitos pretendentes.", "OK");
    }

    private async void mary_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Mary Sharma", "Lady Mary � a matriarca da fam�lia Sharma e � retratada como uma figura carinhosa e preocupada com o bem-estar de suas filhas. Ela desempenha um papel ativo na busca por maridos adequados para Edwina e Kate.", "OK");
    }
}