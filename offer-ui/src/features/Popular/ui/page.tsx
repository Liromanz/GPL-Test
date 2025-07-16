import React from "react"
import { PopularCard } from "../../../components/PopularCard/component"
import { PopularSuppliers } from "../model/usePopularSuppliers"



const Popular: React.FC<PopularSuppliers> = ({suppliers}) => {
    return (
        <div className="container">
            <h1 className="text-center m-3">Популярные поставщики</h1>
            {
                suppliers.map((item) => (
                    <PopularCard name={item.name} offerCount={item.offerCount}/>
                ))
            }
        </div>
    )
}


export default Popular