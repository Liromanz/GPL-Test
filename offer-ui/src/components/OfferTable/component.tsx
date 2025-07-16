import { OfferDto } from "../../types/OfferDTO";
import { useOffers } from "./types";


export const OfferTable: React.FC<useOffers> = ({ offers }) => {
    return (
        <table className="table table-striped my-3">
            <thead>
                <tr>
                    <th scope="col">Бренд</th>
                    <th scope="col">Модель</th>
                    <th scope="col">Поставщик</th>
                </tr>
            </thead>
            <tbody>
                {
                    offers.map((item) => (
                        <tr>
                            <td scope="row">{item.brand}</td>
                            <td >{item.model}</td>
                            <td >{item.supplierName}</td>
                        </tr>
                    ))
                }
            </tbody>
        </table>
    )
}