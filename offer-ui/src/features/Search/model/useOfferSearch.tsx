import { useCallback, useState } from "react";
import { OfferSearchDto } from "../../../types/OfferDTO"
import fetchOffers from "../api/offerApi";


export type OfferSearch = {
    resultedSearchOffers: OfferSearchDto
    onSearch: (term: string) => void
}

export const useOfferSearch = () => {
  const [offerSearch, setOfferSearch] = useState<OfferSearchDto>({ offers: [], totalCount: 0 });

  const search = useCallback(async (term: string) => {
    try {
      const data = await fetchOffers(term);
      setOfferSearch(data);
    } catch (e) {
        console.error("Error fetching offers:", e);
    }
  }, []);

  return { offerSearch, search };
};