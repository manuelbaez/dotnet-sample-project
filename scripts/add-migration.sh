cd $( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )
cd ../DataAccess && dotnet ef --startup-project ../Api migrations add "$1"