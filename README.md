# My Finance Web
MyFinance - Projeto do Curso de Pós-Graduação em Engenharia de Software da PUC-MG

## Arquitetura

A figura abaixo representa a modelagem lógica do banco de dados da aplicação no modelo de DER - Diagrama de Entidades e Relacionamentos.

<img src = "docs\DER.png" alt = "diagram">

## 💻 Pré - Requisitos

Antes de iniciar, por favor verificar se possui/instalou os seguintes requisitos:
- Versão mais recente do Visual Studio Code
- Extensão do C# para Visual Studio Code
-.NET Core SDK 6.0, o qual pode ser obtido através do link "https://dotnet.microsoft.com/en-us/download"
- Última versão do Git, a qual pode ser adquirida por meio do link "https://git-scm.com/downloads"
- Última versão do C# extensions, o qual deve ser instalado no Visual Studio Code

## Google Charts

Neste projeto, utilizamos o Google Charts para criação do gráfico de pizza referente as transações.

Dessa forma, foi necessário incorporar a biblioteca e importar o core do Google Chart Tools.


<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script> //Realizando a leitura da API AJAX
    <script>
        let receita = @receita.ToString().Replace(",",".");
        let despesas = @despesas.ToString().Replace(",",".");
        
        google.charts.load('current', {'packages':['corechart']});
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Tipo', 'Valor', { role: 'annotation' }],
                ['Receitas', receita, receita.toString()],
                ['Despesas',  despesas, despesas.toString()],
            ]);
            var options = { title:'Receitas vs Despesas por Período',
                            width:300,
                            height:300,
                            legend: {
                                position: 'bottom',
                                textStyle: {
                                    fontSize: 10, 
                                    bold: true,
                                },
                            },
                            sliceVisibilityThreshold: 0,
                            pieSliceText: 'value',
                            colors: ['#0052cc', 'orange']
                          };
            var chart = new google.visualization.PieChart(document.getElementById('grafico'));
            chart.draw(data, options);
        }
    </script>  
    <div id="grafico"></div>
## 🌈 Contribuidores<br>

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/48913154?v=4" width="100px;" alt="Foto do Victor Marques Silva no GitHub"/><br>
        <sub>
          <b>Victor Marques Silva</b>
        </sub>
      </a>
    </td>
    </td>
  </tr>
</table>

## 📫 Contribuia

- Realize um Fork desse repositório
- Crie um branch através do comando: git checkout -b <branch_name>
- Faça as mudanças que achar necessário e as confirme: git commit -m 'mensagem commit'
- Mande para o branch original: git push origin 'nome do projeto'/'local'
- Crie um pull request.
  


