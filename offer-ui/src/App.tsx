import { BrowserRouter, Route, Routes } from 'react-router-dom'
import './App.css'
import Search from './features/Search/ui/page'
import Popular from './features/Popular/ui/page'
import { MainLayout } from './layouts/MainLayout'
import { useEffect, useState } from 'react'
import { OfferSearchDto } from './types/OfferDTO'
import { useOfferSearch } from './features/Search/model/useOfferSearch'
import { SupplierDto } from './types/SupplierDTO'
import { usePopularSuppliers } from './features/Popular/model/usePopularSuppliers'


const API_URL = 'http://localhost:5092'


function App() {
  const { popularSuppliers } = usePopularSuppliers();
  const { offerSearch, search: handleSearch } = useOfferSearch();

  return (
    <BrowserRouter>
      <Routes>
        <Route element={<MainLayout />}>
          <Route path="/" element={<Search resultedSearchOffers={offerSearch} onSearch={handleSearch} />}></Route>
          <Route path="/popular" element={<Popular suppliers={popularSuppliers} />}></Route>
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
