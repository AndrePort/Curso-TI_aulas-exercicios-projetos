#limpa terminal
Clear-Host

#entradada de dados
Write-Output "Conversão de Kelvin para Celcius";
Write-Output "================================";

$nome = Read-Host "Digite seu nome";
Write-Output "`n--------------------------------";
Write-Output "Seja muito Bem-vindo $nome";
Write-Output "--------------------------------";

Write-Output "$nome vamos realizar a conversão!";
Write-Output "`nQual a temperatura em Kelvin?";
[float]$kelvin = Read-Host 

#area de calculos
[float] $celcius = $kelvin - 273.15;

#limpa terminal
Clear-Host

#saida de dados
Write-Output "Conversão de Kelvin para Celcius";
Write-Output "================================="
Write-Output "`nA conversão de $kelvin°K para Celcius é: $celcius°C";

#Encerramento do Programa
Read-Host "`nPressione qualquer tecla para sair..."
Clear-Host
