import { OfferTable } from "../../components/OfferTable/component"
import { OfferDto, OfferSearchDto } from "../../types/OfferDTO";

export interface passedOfferSearchResult {
    resultedSearchOffers: OfferSearchDto
    onSearch: (term: string) => void
}

const Search: React.FC<passedOfferSearchResult> = ({ resultedSearchOffers, onSearch }) => {
    return (
        <div className="container">
            <h1 className="text-center m-3">Поиск по офферам</h1>
            <p className="text-center">Введите одно из значений - марка, модель или поставщик автомобиля. Поиск выдаст все варианты, найденные в офферах</p>
            <div className="d-flex w-100">
                <input type="text" className="flex-grow-1"
                    onChange={(e) => onSearch(e.target.value)} />
            </div>
            <p className="text-center m-3"> Всего офферов: {resultedSearchOffers.totalCount}</p>
            <OfferTable offers={resultedSearchOffers.offers} />
        </div>
    )
}


export default Search