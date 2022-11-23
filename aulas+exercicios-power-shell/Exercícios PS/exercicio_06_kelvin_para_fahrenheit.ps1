#limpa terminal
Clear-Host

#entradada de dados
Write-Output "Conversão de Kelvin para Fahrenheit";
Write-Output "===================================";

$nome = Read-Host "Digite seu nome";
Write-Output "`n-----------------------------------";
Write-Output "Seja muito Bem-vindo $nome";
Write-Output "-----------------------------------";

Write-Output "$nome vamos realizar a conversão!";
Write-Output "`nQual a temperatura em Kelvin?";
[float]$kelvin = Read-Host 

#area de calculos
[float] $fahrenheit = 1.8 * ( $kelvin - 273) + 32;

#limpa terminal
Clear-Host

#saida de dados
Write-Output "Conversão de Kelvin para Fahrenheit";
Write-Output "===================================";
Write-Output "`nA conversão de $kelvin K para Fahrenheit é: $fahrenheit°F";

#Encerramento do Programa
Read-Host "`nPressione qualquer tecla para sair..."
Clear-Host
