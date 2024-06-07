namespace QueridoLeitor.Paginas;

public partial class PersonagemPage : ContentPage
{
	public PersonagemPage()
	{
        InitializeComponent();
    }

    private async void dap_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Daphne Bridgerton", "A quarta filha e a personagem principal da primeira temporada da série, Daphne é inteligente, gentil e determinada a encontrar o amor verdadeiro na sociedade de Londres.", "OK");
    }

    private async void simon_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Simon Basset", "Também conhecido como o Duque de Hastings, Simon é o interesse amoroso de Daphne na primeira temporada. Ele é retratado como um homem aristocrático, charmoso e com um passado complicado que o torna relutante em se casar e ter filhos.", "OK");
    }

    private async void kate_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Kate Sharma", "Kate é a meia-irmã mais velha de Edwina e se torna a protagonista da segunda temporada de \"Bridgerton\". Ela é retratada como uma mulher inteligente, corajosa e prática, que tem um forte senso de dever para com sua família.", "OK");
    }

    private async void antho_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Anthony Bridgerton", "O filho mais velho e o Visconde Bridgerton, Anthony é responsável por proteger e guiar sua família após a morte do pai. Ele é retratado como um homem sério e responsável, embora também lute com suas próprias questões emocionais e desejos.", "OK");
    }

    private async void pen_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Penelope Featherington", "A melhor amiga de Eloise e membro da família Featherington. Penelope é retratada como uma jovem inteligente, mas muitas vezes é subestimada por sua família e pela sociedade devido à sua timidez e aparência modesta.", "OK");
    }

    private async void colin_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Colin Bridgerton", "O terceiro filho, Colin é retratado como um jovem charmoso e aventureiro que busca encontrar seu lugar na sociedade e descobrir o verdadeiro amor.", "OK");
    }

    private async void eloise_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Eloise Bridgerton", "A quinta filha, Eloise é retratada como uma jovem rebelde e determinada a desafiar as expectativas de gênero da sociedade. Ela é inteligente, perspicaz e tem uma mente afiada.", "OK");
    }

    private async void violet_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Violet Bridgerton", "A matriarca da família Bridgerton, Lady Violet é retratada como uma mãe amorosa e protetora que deseja o melhor para seus filhos. Ela é uma figura influente na alta sociedade de Londres e está sempre atenta às intrigas e alianças políticas.", "OK");
    }

    private async void bene_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Benedict Bridgerton", "O segundo filho da família Bridgerton, Benedict é um artista talentoso que muitas vezes se sente deslocado em relação às expectativas de sua família. Ele busca explorar sua própria identidade e paixões fora das convenções sociais.", "OK");
    }

    private async void greg_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Gregory Bridgerton", "O caçula da família, Gregory é retratado como um jovem idealista que ainda está descobrindo seu lugar no mundo. Sua inocência e otimismo são características marcantes de sua personalidade.", "OK");
    }

    private async void hya_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Hyacinth Bridgerton", "A filha mais nova e a personagem mais jovem da série, Hyacinth é uma personagem vívida e espirituosa, muitas vezes proporcionando momentos de humor e franqueza na série.", "OK");
    }

    private async void fran_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Francesca Bridgerton", "A sexta filha, Francesca é uma presença mais discreta na série, mas ainda assim tem sua própria história e desenvolvimento ao longo da trama.", "OK");
    }

    private async void danb_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Danbury", "Uma figura influente na alta sociedade de Londres e uma mentora para Simon. Ela é retratada como uma mulher forte e perspicaz que valoriza a independência e a determinação.", "OK");
    }

    private async void rainh_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Rainha Charlotte", "A esposa do Rei George III, a Rainha Charlotte é uma figura importante na alta sociedade de Londres. Ela é retratada como uma mulher perspicaz e influente, cujas opiniões e decisões afetam o curso dos eventos na série.", "OK");
    }

    private async void edw_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Edwina Sharma", "Edwina é a irmã mais nova da família Sharma e é apresentada como uma das debutantes mais cobiçadas da temporada em que é apresentada. Ela é retratada como gentil, graciosa e desejada por muitos pretendentes.", "OK");
    }

    private async void mary_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Lady Mary Sharma", "Lady Mary é a matriarca da família Sharma e é retratada como uma figura carinhosa e preocupada com o bem-estar de suas filhas. Ela desempenha um papel ativo na busca por maridos adequados para Edwina e Kate.", "OK");
    }
}