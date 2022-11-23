Clear-Host
do
{
    Write-Host "Bem vindo";
    [int]$idade = Read-Host "Digite a sua idade";
    if($idade -ge 18)
    {
        Write-Host "Você é maior de idade";
    }
    else 
    {
        Write-Host "Você é menor de idade";
    }

   [string]$continuar = Read-Host "`nDigite a tecla S para continuar";
}
while($continuar -eq "s");