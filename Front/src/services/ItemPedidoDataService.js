import http from "../http-common.js"

class ItemPedidoDataService{
    listarPorPedido(id){
        return http.get('/itemPedido/pedido/'+id)
    }
    cadastrar(itemPedido){
        return http.post('/itemPedido', itemPedido)
    }
    atualizar(id, itemPedido){
        return http.put(`/itemPedido/${id}`, itemPedido)
    }
    obterPorId(id){
        return http.get(`/itemPedido/${id}`)
    }
    async deletar(id){
        return await http.delete("/itemPedido/"+id)
    }
}

export default new ItemPedidoDataService()