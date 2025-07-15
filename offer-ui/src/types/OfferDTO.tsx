export type OfferDto = {
  brand: string
  model: string
  supplierName: string
}

export type OfferSearchDto = {
    offers: OfferDto[]
    totalCount: number
}