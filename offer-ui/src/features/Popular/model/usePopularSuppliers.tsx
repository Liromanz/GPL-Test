import { useCallback, useEffect, useState } from "react";
import { SupplierDto } from "../../../types/SupplierDTO"
import fetchOffers from "../../Search/api/offerApi";
import { fetchPopularSuppliers } from "../api/supplierApi";

export type PopularSuppliers = {
    suppliers: SupplierDto[]
}

export const usePopularSuppliers = () => {
    const [popularSuppliers, setPopularSuppliers] = useState<SupplierDto[]>([])

    useEffect(() => {
        const load = async () => {
            try {
                const data = await fetchPopularSuppliers();
                if (data) setPopularSuppliers(data);
            } catch (e) {
                console.error("Error fetching suppliers:", e);
            }
        };
        load();
    }, []);

    return { popularSuppliers }
};