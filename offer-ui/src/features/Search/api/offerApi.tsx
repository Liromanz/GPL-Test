import { OfferSearchDto } from "../../../types/OfferDTO";

const fetchOffers = async (searchTerm: string) => {
    try {
        const API_URL = process.env.REACT_APP_API_URL;
        const url = searchTerm
            ? `${API_URL}/api/offers/search?searchTerm=${encodeURIComponent(searchTerm)}`
            : `${API_URL}/api/offers/search`;

        const response = await fetch(url);
        if (!response.ok) 
            throw new Error("Failed to fetch");
        return response.json();
    }
    catch (error) {
        console.error("Error fetching offers:", error);
    }
};

export default fetchOffers;