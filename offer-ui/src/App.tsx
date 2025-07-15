import { BrowserRouter, Route, Routes } from 'react-router-dom'
import './App.css'
import Search, { passedOfferSearchResult } from './pages/Search/page'
import Popular from './pages/Popular/page'
import { MainLayout } from './layouts/MainLayout'
import { useEffect, useState } from 'react'
import { SupplierDto } from './components/PopularCard/component'
import { OfferSearchDto } from './types/OfferDTO'


const API_URL = 'http://localhost:5092'


function App() {
  const [popularSuppliers, setPopularSuppliers] = useState<SupplierDto[]>([])
  const [offerSearch, setOfferSearch] = useState<OfferSearchDto>({ offers: [], totalCount: 0 })
  const [searchTerm, setSearchTerm] = useState<string>('')

  useEffect(() => {
    fetchPopularSuppliers()
    fetchOffers()
  }, [])

  useEffect(() => {
    fetchOffers()
  }, [searchTerm])

  const fetchPopularSuppliers = async () => {
    try {
      const response = await fetch(`${API_URL}/api/suppliers/popular`)
      if (!response.ok)
        throw new Error('Failed to fetch')

      const data: SupplierDto[] = await response.json()
      setPopularSuppliers(data)
    }
    catch (error) {
      console.error('Error fetching suppliers:', error)
    }
  }

  const fetchOffers = async () => {
    try {
      const url = searchTerm
        ? `${API_URL}/api/offers/search?searchTerm=${encodeURIComponent(searchTerm)}`
        : `${API_URL}/api/offers/search`

      const response = await fetch(url)
      if (!response.ok)
        throw new Error('Failed to fetch');

      const data: OfferSearchDto = await response.json()
      setOfferSearch(data)
    }
    catch (error) {
      console.error('Error fetching offers:', error)
    }
  }


  const handleSearch = (term: string) => {
    setSearchTerm(term)
  };
  

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
