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

    getUserDetailsFromUserId: async function (userId) {
        try {
            const response = await axios.get(`/Home/GetUserDetailsFromUserId?userId=${userId}`);
            indexScript.displayUserDetails(response.data.items);
            $('#captionsBox').fadeIn();
        }
        catch (error) {
            console.log('getUserId', error);
        }
    },

    displayUserDetails: function (data) {

        data.forEach((item) =>
        {
            $('#captionsRow').append(`
                <div class='col-3' >
                    <p>${item.media.caption.text}</p>
                </div>`);
        })
    },

    getPopulateUserInfo: async function() {

        let username = $('#username').val();
        let user = await indexScript.getUserId(username);

        $('#userInfo').html(`
            <p><strong>Username:</strong> ${user.username}</p>
            <p><strong>Attempts:</strong> ${user.attempts}</p>
            <button class='btn btn-primary' onclick='indexScript.getUserDetailsFromUserId(${user.userId})'>View more</button>
        `);
    }
}