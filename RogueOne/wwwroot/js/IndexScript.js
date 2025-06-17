var indexScript = {
    getUserId: async function (username) {
        try
        {
            const response = await axios.get(`/Home/GetUserId?username=${username}`);

            return response.data;
        }
        catch (error)
        {
            console.log('getUserId', error);
        }
    },
}