import axios from 'axios'

const api = axios.create({
    baseURL: "https://localhost:7260",
    headers: {
        "Content-Type": "application/json"
    }
})

export default api