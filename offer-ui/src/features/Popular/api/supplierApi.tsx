import { SupplierDto } from "../../../types/SupplierDTO";

export const fetchPopularSuppliers = async () => {
    try {
        const API_URL = process.env.REACT_APP_API_URL;

        const response = await fetch(`${API_URL}/api/suppliers/popular`)
        if (!response.ok)
            throw new Error('Failed to fetch')

        return response.json();
    }
    catch (error) {
        console.error('Error fetching suppliers:', error)
    }
}