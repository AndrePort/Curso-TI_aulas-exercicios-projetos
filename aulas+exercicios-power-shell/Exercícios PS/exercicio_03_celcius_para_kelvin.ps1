#limpa terminal
Clear-Host

#entradada de dados
Clear-Host
Write-Output "Conversão de Celcius para Kelvin";
Write-Output "==================================";

$nome = Read-Host "Digite seu nome";
Write-Output "`n----------------------------------";
Write-Output "Seja muito Bem-vindo $nome";
Write-Output "----------------------------------";

Write-Output "$nome vamos realizar a conversão!";
Write-Output "`nQual a temperatura em Celcius?";
[float]$celcius = Read-Host 

#area de calculos
[float]$kelvin = $celcius + 273.15;

#saida de dados
Clear-Host
Write-Output "Conversão de Celcius para Kelvin";
Write-Output "================================="
Write-Output "`nA conversão de $celcius°C para Kelvin é: $kelvin°K";

#Encerramento do Programa
Read-Host "`nPressione qualquer tecla para sair..."
Clear-Host
