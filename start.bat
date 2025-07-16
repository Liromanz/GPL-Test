@echo off

echo BUILD - API
cd Offer-API
dotnet build
start "Offer_API" dotnet run
cd ..

echo BUILD - REACT
cd offer-ui
npm start
cd ..