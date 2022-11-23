#limpa terminal
Clear-Host

#entradada de dados
Write-Output "Conversão de Celsius para Fahrenheit";
Write-Output "====================================";

$nome = Read-Host "Digite seu nome";
Write-Output "`n------------------------------------";
Write-Output "Seja muito Bem-vindo $nome";
Write-Output "------------------------------------";

Write-Output "$nome vamos realizar a conversão!";
Write-Output "`nQual a temperatura em Celcius? ";
[float]$celcius = Read-Host 

#area de calculos
[float]$fahrenheit = $celcius * 9 / 5 + 32;

#saida de dados
Clear-Host
Write-Output "Conversão de Celsius para Fahrenheit";
Write-Output "====================================";
Write-Output "`nA conversão de $celcius°C para Fahrenheit é: $fahrenheit°F";

#Encerramento do Programa
Read-Host "`nPressione qualquer tecla para sair..."
Clear-Host
