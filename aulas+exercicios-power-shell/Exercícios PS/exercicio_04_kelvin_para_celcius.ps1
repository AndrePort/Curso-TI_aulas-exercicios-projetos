#limpa terminal
Clear-Host

#entradada de dados
Write-Output "Conversão de Fahrenheit para Kelvin";
Write-Output "===================================";

$nome = Read-Host "Digite seu nome";
Write-Output "`n-----------------------------------";
Write-Output "Seja muito Bem-vindo $nome";
Write-Output "-----------------------------------";

Write-Output "$nome vamos realizar a conversão!";
Write-Output "`nQual a temperatura em Fahrenheit?";
[float]$fahrenheit = Read-Host 

#area de calculos
[float] $kelvin = ($fahrenheit + 459.67) * 5 / 9;

#limpa terminal
Clear-Host

#saida de dados
Write-Output "Conversão de Fahrenheit para Kelvin";
Write-Output "===================================";
Write-Output "`nA conversão de $fahrenheit°F para Kelvin é: $kelvin°K";

#Encerramento do Programa
Read-Host "`nPressione qualquer tecla para sair..."
Clear-Host

